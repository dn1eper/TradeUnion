using System;
using System.Windows.Forms;
using TradeUnion.Model;
using TradeUnion.Extensions;

namespace TradeUnion.Forms
{
    partial class EventEditForm : Form
    {
        public Employee Employee { get; set; }
        public Event Event { get; set; }

        public EventEditForm()
        {
            InitializeComponent();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MM-yyyy";
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (Employee != null)
            {
                nameTextBox.Text = Employee.Name;
                titleTextBox1.Clear();
                sumTextBox.Clear();
                titleTextBox1.Focus();
            }
        }

        private void OnChangesAccepted(object sender, EventArgs e)
        {
            if (Event == null)
            {
                Event = new Event();
            }
            Event.Title = titleTextBox1.Text;
            Event.Sum = Convert.ToInt32(sumTextBox.Text);
            Event.Date = dateTimePicker.Value;
            Event.EmployeeID = Employee.ID;
        }

        private void OnEventChanged(object sender, EventArgs e)
        {
            saveEventBtn.Enabled = !titleTextBox1.Text.IsEmpty() && !sumTextBox.Text.IsEmpty();
        }

        private void OnSumKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void OnKeyDownEventEditForm(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if (e.KeyCode == Keys.Enter && saveEventBtn.Enabled)
            {
                OnChangesAccepted(sender, e);
            }
        }
    }
}
