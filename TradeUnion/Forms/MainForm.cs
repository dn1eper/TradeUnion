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
            employees = storage.GetAllEmployee();
            employees.ForEach(emp =>
            {
                empListBox.Items.Add(emp);
            });
            eventTable.Event = storage.GetAllExtendedEvents();
            CountEmpLabel.Text = "Всего сотрудников: " + employees.Count;
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.N:
                    OnCreateEmployee(this, new EventArgs());
                    return true;
                case Keys.Delete:
                    if (deleteEmployee.Enabled)
                    {
                        OnDeleteEmployee(this, new EventArgs());
                        return true;
                    }
                    else return base.ProcessCmdKey(ref msg, keyData);
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void OnCreateEmployee(object sender, EventArgs e)
        {
            employeeEditor.Employee = null;
            if (employeeEditor.ShowDialog() == DialogResult.OK)
            {
                empListBox.Items.Add(employeeEditor.Employee);
                employees.Add(employeeEditor.Employee);
                empListBox.SelectedItem = employeeEditor.Employee;
                storage.Insert(employeeEditor.Employee);
                CountEmpLabel.Text = "Всего сотрудников: " + employees.Count;
            }
        }

        private void OnEditEmployee(object sender, EventArgs e)
        {
            employeeEditor.Employee = empListBox.SelectedItem as Employee;
            if (employeeEditor.ShowDialog() == DialogResult.OK)
            {
                empListBox.UpdateSelectedItem();
                storage.Update(employeeEditor.Employee);
            }
        }

        private void OnDeleteEmployee(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить сотрудника " + empListBox.SelectedItem.ToString(), "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Employee emp = empListBox.SelectedItem as Employee;
                emp.IsFired = 1;
                storage.Update(emp);
                empListBox.DeleteSelectedItems();
                employees.Remove(emp);
                CountEmpLabel.Text = "Всего сотрудников: " + employees.Count;
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

        private void OnCreateEvent(object sender, EventArgs e)
        {
            eventEditor.Employee = empListBox.SelectedItem as Employee;
            eventEditor.Event = null;
            if (eventEditor.ShowDialog() == DialogResult.OK)
            {
                storage.Insert(eventEditor.Event);
                eventTable.Event.Add(new ExtendedEvent(eventEditor.Event, eventEditor.Employee));
            }
        }

        private void OnShowEventTable(object sender, EventArgs e)
        {
            eventTable.ShowDialog();
        }

        private void OnShowEmployeeEvents(object sender, EventArgs e)
        {
            eventTable.Employee = empListBox.SelectedItem as Employee;
            eventTable.ShowDialog();
        }
    }
}