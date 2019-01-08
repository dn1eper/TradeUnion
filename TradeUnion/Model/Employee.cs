using System;
using System.Data.SQLite.Generic;
using System.Data.SQLite.EF6;
using System.Data.SQLite.Linq;
using System.Data.SQLite;
using SQLite;

namespace TradeUnion.Model
{
    class Employee
    {
        [PrimaryKey, AutoIncrement, Unique]
        public int ID { get; set; }
        [MaxLength(50), NotNull]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Inn { get; set; }
        
        public bool Like(string str)
        {
            return ToString().Contains(str);
        }

        public override bool Equals(object obj)
        {
            return obj is Employee && obj.GetHashCode() == GetHashCode();
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format(
                "{0} {1}",
                Name,
                Inn
            );
        }
    }
}
