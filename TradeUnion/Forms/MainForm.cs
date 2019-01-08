using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradeUnion.Extensions;
using TradeUnion.Model;

namespace TradeUnion.Forms
{
    public partial class Main : Form
    {
        private EmployeeEditForm editor { get; set; }
        private Storage storage { get; set; }
        private List<Employee> employees { get; set; }

        public Main()
        {
            editor = new EmployeeEditForm();
            storage = new Storage();
            InitializeComponent();
            employees = storage.getAllEmployee();
            employees.ForEach(emp =>
            {
                empListBox.Items.Add(emp);
            });
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            editor.Dispose();
            storage.Dispose();
            base.OnClosing(e);
        }

        private void OnShowEmployee(object sender, EventArgs e)
        {
            empGroupBox.Visible = true;
            // eventGroupBox.Visible = false;
            // empGroupBox.BringToFront();
            // eventGroupBox.SendToBack();
        }

        private void OnShowEvent(object sender, EventArgs e)
        {
            empGroupBox.Visible = false;
            // eventGroupBox.Visible = true;
            // eventGroupBox.BringToFront();
            // empGroupBox.SendToBack();
        }

        #region Employee
        private void OnEmployeeSelectionChanged(object sender, EventArgs e)
        {
            editEmpBtn.Enabled = deleteEmpBtn.Enabled = editToolStripMenuItem.Enabled = deleteToolStripMenuItem.Enabled = empListBox.SelectedItem != null;
        }


        private void OnCreateEmployee(object sender, EventArgs e)
        {
            editor.Employee = null;
            if (editor.ShowDialog() == DialogResult.OK)
            {
                empListBox.Items.Add(editor.Employee);
                storage.insert(editor.Employee);
            }
        }

        private void OnEditEmployee(object sender, EventArgs e)
        {
            editor.Employee = empListBox.SelectedItem as Employee;
            if (editor.ShowDialog() == DialogResult.OK)
            {
                empListBox.UpdateSelectedItem();
                storage.update(editor.Employee);
            }
        }

        private void OnDeleteEmployee(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить сотрудника " + empListBox.SelectedItem.ToString(), "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                storage.delete(empListBox.SelectedItem as Employee);
                empListBox.DeleteSelectedItems();
            }
        }

        private void OnSearchEmployee(object sender, EventArgs e)
        {
            empListBox.Items.Clear();
            employees.ForEach(emp =>
            {
                if (emp.ToString().ToLower().Contains(empSearchTextBox.Text.ToLower())) {
                    empListBox.Items.Add(emp);
                }
            });
        }

        private void OnSerchEmployeeKetEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OnSearchEmployee(sender, e);
            }
        }
        #endregion

        #region Event

        #endregion
    }
}
