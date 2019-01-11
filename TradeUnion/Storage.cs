using System;
using System.Collections.Generic;
using SQLite;
using System.IO;
using System.Reflection;S
using TradeUnion.Model;

namespace TradeUnion
{
    class Storage : IDisposable
    {
        public SQLiteConnection DB;
        private string path => Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "storage");
        private string file => Path.Combine(path, "storage.db");

        public Storage()
        {
            Directory.CreateDirectory(path);   
            if (File.Exists(file))
            {
                DB = new SQLiteConnection(file, SQLiteOpenFlags.ReadWrite, true);
            }
            else
            {
                DB = new SQLiteConnection(file);
                DB.CreateTable<Employee>();
                DB.CreateTable<Event>();
            }
        }

        public List<Employee> getAllEmployee()
        {
            return DB.Query<Employee>("SELECT * FROM Employee");
        }

        public List<ExtendedEvent> getAllEvent()
        {
            return DB.Query<ExtendedEvent>(
                "SELECT Event.ID ID, Title, Date, Sum, Employee.Name EmployeeName, Employee.Inn EmployeeInn, Employee.ID EmployeeID " +
                "FROM Event " +
                "LEFT JOIN Employee ON Event.EmployeeID = Employee.ID"
            );
        }

        public int insert(object obj)
        {
            return DB.Insert(obj);
        }

        public int update(object obj)
        {
            return DB.Update(obj);
        }

        public int delete(object obj)
        {
            return DB.Delete(obj);
        }

        public void Dispose()
        {
            if (DB != null) DB.Dispose();
        }
    }
}
