using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TradeUnion.Extensions;
using TradeUnion.Model;

namespace TradeUnion.Forms
{
    public partial class Main : Form
    {
        private EmployeeEditForm employeeEditor { get; set; }
        private EventEditForm eventEditor { get; set; }
        private EventTableForm eventTable { get; set; }
        private Storage storage { get; set; }
        private List<Employee> employees { get; set; }

        public Main()
        {
            // initialize all components
            storage = new Storage();
            employeeEditor = new EmployeeEditForm();
            eventEditor = new EventEditForm();
            eventTable = new EventTableForm(storage);
            InitializeComponent();
            // get data from db
            employees = storage.getAllEmployee();
            employees.ForEach(emp =>
            {
                empListBox.Items.Add(emp);
            });
            eventTable.Event = storage.getAllEvent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            employeeEditor.Dispose();
            storage.Dispose();
            base.OnClosing(e);
        }

        private void OnExit(object sender, EventArgs e)
        {
            Close();
        }

        private void OnEmployeeSelectionChanged(object sender, EventArgs e)
        {
            editEmployee.Enabled = deleteEmployee.Enabled = createEvent.Enabled = empListBox.SelectedItem != null;
        }

        private void OnCreateEmployee(object sender, EventArgs e)
        {
            employeeEditor.Employee = null;
            if (employeeEditor.ShowDialog() == DialogResult.OK)
            {
                empListBox.Items.Add(employeeEditor.Employee);
                storage.insert(employeeEditor.Employee);
            }
        }

        private void OnEditEmployee(object sender, EventArgs e)
        {
            employeeEditor.Employee = empListBox.SelectedItem as Employee;
            if (employeeEditor.ShowDialog() == DialogResult.OK)
            {
                empListBox.UpdateSelectedItem();
                storage.update(employeeEditor.Employee);
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

        private void OnSerchEmployeeKeyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OnSearchEmployee(sender, e);
            }
        }

        private void OnCreateEvent(object sender, EventArgs e)
        {
            eventEditor.Employee = empListBox.SelectedItem as Employee;
            eventEditor.Event = null;
            if (eventEditor.ShowDialog() == DialogResult.OK)
            {
                storage.insert(eventEditor.Event);
                eventTable.Event.Add(new ExtendedEvent(eventEditor.Event, eventEditor.Employee));
            }
        }

        private void OnShowEventTable(object sender, EventArgs e)
        {
            eventTable.ShowDialog();
        }
    }
}