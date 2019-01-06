using System;
using SQLite;

namespace TradeUnion.Model
{
    [Serializable]
    class Event
    {
        [PrimaryKey, AutoIncrement, Unique]
        public int ID { get; set; }
        [Unique, NotNull]
        public string Title { get; set; }
        [NotNull]
        public DateTime Date { get; set; }
        [NotNull]
        public int Sum { get; set; }
        [NotNull]
        public int EmployeeID { get; set; }     

        public override bool Equals(object obj)
        {
            return obj is Event && obj.GetHashCode() == GetHashCode();
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
