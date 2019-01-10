﻿using SQLite;

namespace TradeUnion.Model
{
    [Table("Employee")]
    class Employee
    {
        [PrimaryKey, AutoIncrement, Unique]
        public int ID { get; set; }
        [MaxLength(50), NotNull]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Inn { get; set; }

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
