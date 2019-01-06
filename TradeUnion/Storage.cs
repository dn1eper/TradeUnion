using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using TradeUnion.Model;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

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
                // Создаем базу данных с табличками
                SQLite3.Config(SQLite3.ConfigOption.Serialized);
                DB = new SQLiteConnection(file);
                DB.CreateTable<Employee>();
                DB.CreateTable<Event>();
            }
        }

        public List<Employee> getAllEmployee()
        {
            return DB.Query<Employee>("select * from Employee");
        }

        public int addEmployee(Employee emp)
        {
            int id = DB.Insert(emp);
            emp.ID = id;
            return id;
        }

        public void Dispose()
        {
            if (DB != null) DB.Dispose();
        }
    }
}
