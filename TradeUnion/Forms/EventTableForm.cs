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
        private List<ExtendedEvent> findEvent;
        private Storage storage;

        public EventTableForm(Storage stor)
        {
            storage = stor;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            dataGridView.DataSource = Event;
        }

        private void OnSearchEvent(object sender, EventArgs e)
        {
            findEvent = new List<ExtendedEvent>();
            Event.ForEach(ev =>
            {
                if (ev.Like(SearchTextBox.Text))
                {
                    findEvent.Add(ev);
                }
            });
            dataGridView.DataSource = findEvent;
        }

        private void OnDeleteEvent(object sender, EventArgs e)
        {
            ExtendedEvent selectedExtendedEvent = dataGridView.SelectedRows[0].DataBoundItem as ExtendedEvent;
            if (MessageBox.Show("Вы уверены что хотите удалить помощь " + selectedExtendedEvent.Title, "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Event.Remove(selectedExtendedEvent);
                dataGridView.DataSource = null;
                dataGridView.DataSource = Event;
                storage.delete(selectedExtendedEvent.Event);
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

            if (findEvent == null) findEvent = Event;

            for (int i = 2; i <= findEvent.Count; i++)
            {
                workSheet.Cells[i, 1] = findEvent[i - 2].EmployeeName;
                workSheet.Cells[i, 2] = findEvent[i - 2].EmployeeInn;
                workSheet.Cells[i, 3] = findEvent[i - 2].Title;
                workSheet.Cells[i, 4] = findEvent[i - 2].Sum;
                workSheet.Cells[i, 5] = findEvent[i - 2].Date.ToString("dd.mm.yyyy");
            }
            
            // Открываем созданный excel-файл
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }
    }
}

