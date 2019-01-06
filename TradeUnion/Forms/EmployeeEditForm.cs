using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void OnChanged(object sender, EventArgs e)
        {
            SaveButton.Enabled = !nameTextBox.Text.IsEmpty();
        }
    }
}
