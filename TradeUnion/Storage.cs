using System;
using System.Collections.Generic;
using SQLite;
using System.IO;
using System.Reflection;
using TradeUnion.Model;

namespace TradeUnion
{
    internal class Storage : IDisposable
    {
        public SQLiteConnection DB;
        private static string path => Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "storage");
        private static string file => Path.Combine(path, "storage.db");

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

        public List<Employee> GetAllEmployee()
        {
            return DB.Query<Employee>("SELECT * FROM Employee WHERE IsFired = 0");
        }

        public List<ExtendedEvent> GetAllExtendedEvents()
        {
            return DB.Query<ExtendedEvent>(
                "SELECT Event.ID ID, Title, Date, Sum, Employee.Name EmployeeName, Employee.Inn EmployeeInn, Employee.ID EmployeeID " +
                "FROM Event " +
                "LEFT JOIN Employee ON Event.EmployeeID = Employee.ID"
            );
        }

        public List<Event> GetAllEvents()
        {
            return DB.Query<Event>("SELECT * FROM Event FROM Event ");
        }

        public int Insert(object obj)
        {
            return DB.Insert(obj);
        }

        public int Update(object obj)
        {
            return DB.Update(obj);
        }

        public int Delete(object obj)
        {
            return DB.Delete(obj);
        }

        public void Dispose()
        {
            DB?.Dispose();
        }
    }
}
