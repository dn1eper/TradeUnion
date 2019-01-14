using System;
using System.ComponentModel;
using Microsoft.Office.Interop.Excel;

namespace TradeUnion.Model
{
    class ExtendedEvent : Event
    {
        public string EmployeeName { get; set; }
        public string EmployeeInn { get; set; }

        public ExtendedEvent() {}

        public ExtendedEvent(Event ev, Employee emp)
        {
            ID = ev.ID;
            Title = ev.Title;
            Sum = ev.Sum;
            Date = ev.Date.Date;
            EmployeeID = emp.ID;
            EmployeeName = emp.Name;
            EmployeeInn = emp.Inn;
        }

        public Event Event
        {
            get => new Event
            {
                ID = ID,
                Title = Title,
                Sum = Sum,
                Date = Date,
                EmployeeID = EmployeeID,
            };
        }

        public bool Like (string searchStr)
        {
            return String.Concat(Title, " ", EmployeeName, " ", EmployeeInn, " ", Date.ToString()).ToLower().Contains(searchStr.ToLower());
        }
    }
}
