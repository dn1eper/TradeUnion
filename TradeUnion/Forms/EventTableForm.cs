using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using TradeUnion.Model;

namespace TradeUnion.Forms
{
    partial class EventTableForm : Form
    {
        public List<ExtendedEvent> Event;
        private List<ExtendedEvent> _findEvent;
        private readonly Storage _storage;

        public EventTableForm(Storage storage)
        {
            _storage = storage;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            dataGridView.DataSource = Event;
        }

        private void OnSearchEvent(object sender, EventArgs e)
        {
            _findEvent = new List<ExtendedEvent>();
            Event.ForEach(ev =>
            {
                if (ev.Like(SearchTextBox.Text))
                {
                    _findEvent.Add(ev);
                }
            });
            dataGridView.DataSource = _findEvent;
        }

        private void OnDeleteEvent(object sender, EventArgs e)
        {
            ExtendedEvent selectedExtendedEvent = dataGridView.SelectedRows[0].DataBoundItem as ExtendedEvent;
            if (MessageBox.Show(@"Вы уверены что хотите удалить помощь " + selectedExtendedEvent.Title, @"Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Event.Remove(selectedExtendedEvent);
                dataGridView.DataSource = null;
                dataGridView.DataSource = Event;
                _storage.Delete(selectedExtendedEvent.Event);
            }
        }

        private void Excel(object sender, EventArgs e)
        {
            // Создаём экземпляр нашего приложения
            Excel.Application excelApp = new Excel.Application();
            // Создаём экземпляр рабочий книги Excel
            Excel.Workbook workBook;
            // Создаём экземпляр листа Excel
            Excel.Worksheet workSheet;

            workBook = excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

            workSheet.Columns[1].ColumnWidth = 24;
            workSheet.Columns[3].ColumnWidth = 20;
            workSheet.Columns[5].ColumnWidth = 10;

            workSheet.Cells[1, 1] = "ФИО";
            workSheet.Cells[1, 2] = "ИНН";
            workSheet.Cells[1, 3] = "Помощь";
            workSheet.Cells[1, 4] = "Сумма";
            workSheet.Cells[1, 5] = "Дата";

            if (_findEvent == null) _findEvent = Event;

            for (int i = 2; i <= _findEvent.Count; i++)
            {
                workSheet.Cells[i, 1] = _findEvent[i - 2].EmployeeName;
                workSheet.Cells[i, 2] = _findEvent[i - 2].EmployeeInn;
                workSheet.Cells[i, 3] = _findEvent[i - 2].Title;
                workSheet.Cells[i, 4] = _findEvent[i - 2].Sum;
                workSheet.Cells[i, 5] = _findEvent[i - 2].Date.ToString("dd.mm.yyyy");
            }
            
            // Открываем созданный excel-файл
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }
    }
}

