using System;
using System.Windows.Forms;
using TradeUnion.Model;
using TradeUnion.Extensions;

namespace TradeUnion.Forms
{
    partial class EmployeeEditForm : Form
    {
        public Employee Employee { get; set; }

        public EmployeeEditForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (Employee != null)
            {
                nameTextBox.Text = Employee.Name;
                innTextBox.Text = Employee.Inn;
            }
            else
            {
                nameTextBox.Clear();
                innTextBox.Clear();
            }
            nameTextBox.Focus();
        }

        private void OnChangesAccepted(object sender, EventArgs e)
        {
            if (Employee == null)
            {
                Employee = new Employee();
            }
            Employee.Name = nameTextBox.Text;
            Employee.Inn = innTextBox.Text;
        }

        private void OnEmployeeChanged(object sender, EventArgs e)
        {
            saveEmpBtn.Enabled = !nameTextBox.Text.IsEmpty();
        }

        private void OnKeyDownEmployeeEditForm(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if (e.KeyCode == Keys.Enter && saveEmpBtn.Enabled)
            {
                OnChangesAccepted(sender, e);
            }
        }
    }
}
