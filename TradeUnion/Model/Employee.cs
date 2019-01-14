using System;
using SQLite;

namespace TradeUnion.Model
{
    [Table("Employee")]
    class Employee : IComparable
    {
        [PrimaryKey, AutoIncrement, Unique]
        public int ID { get; set; }
        [MaxLength(50), NotNull]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Inn { get; set; }
        [NotNull]
        public int IsFired { get; set; } = 0;

        public override bool Equals(object obj)
        {
            return obj is Employee && obj.GetHashCode() == GetHashCode();
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj is Employee)
            {
                return string.Compare(Name, (obj as Employee).Name);
            }
            throw new Exception("obj not Employee");
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
