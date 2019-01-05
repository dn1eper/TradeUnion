using System;

namespace TradeUnion.Model
{
    [Serializable]
    class Event
    {
        public string ID { get; set; }
        public string Title { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Event && obj.GetHashCode() == GetHashCode();
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}
