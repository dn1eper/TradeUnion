using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeUnion.Forms
{
    public partial class Main : Form
    {
        private EmployeeEditForm editor { get; set; }
        private Storage storage { get; set; }

        public Main()
        {
            editor = new EmployeeEditForm();
            storage = new Storage();
            InitializeComponent();
            storage.getAllEmployee().ForEach(emp =>
            {
                employeeListBox.Items.Add(emp);
            });
        }

        

        protected override void OnClosing(CancelEventArgs e)
        {
            // save db
            editor.Dispose();
            base.OnClosing(e);
        }

        private void OnCreate(object sender, EventArgs e)
        {
            editor.Employee = null;
            if (editor.ShowDialog() == DialogResult.OK)
            {
                employeeListBox.Items.Add(editor.Employee);
                storage.addEmployee(editor.Employee);
            }
        }
    }
}
