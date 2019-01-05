using System;

namespace TradeUnion.Model
{
    [Serializable]
    class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Inn { get; set; }
        
        public override bool Equals(object obj)
        {
            return obj is Employee && obj.GetHashCode() == GetHashCode();
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}
