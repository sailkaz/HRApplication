using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HRApplication
{
    public partial class Main : Form
    {
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);
        private List<EmployeeStatus> _employeeStatus;

        public Main()
        {
            InitializeComponent();
            _employeeStatus = EmployeeStatusHelper.GetEmployeeStatus();
            InitEmployeeStatusCombobox();
            RefreshEmployees();
            SetColumnsHeader();
            HideColumns();
        }


        private void HideColumns()
        {
            dgvHRApp.Columns[nameof(Employee.EmployeeStatusId)].Visible = false;
            dgvHRApp.Columns[nameof(Employee.EmployeeStatusName)].Visible = false;
        }

        private void InitEmployeeStatusCombobox()
        {
            cmbEmployeeStatus.DataSource = _employeeStatus;
            cmbEmployeeStatus.DisplayMember = "Name";
            cmbEmployeeStatus.ValueMember = "Id";
        }

        private void RefreshEmployees()
        {
            var employees = _fileHelper.DeserializeFromFile();
            var selectedGroupId = (cmbEmployeeStatus.SelectedItem as EmployeeStatus).Id;
            if (selectedGroupId != 0)
                employees = employees.Where(s => s.EmployeeStatusId == selectedGroupId).ToList();
            dgvHRApp.DataSource = employees;
        }

        private void SetColumnsHeader()
        {
            dgvHRApp.Columns[0].HeaderText = "Id";
            dgvHRApp.Columns[1].HeaderText = "Imię";
            dgvHRApp.Columns[2].HeaderText = "Nazwisko";
            dgvHRApp.Columns[3].HeaderText = "Data Urodzenia";
            dgvHRApp.Columns[4].HeaderText = "Stanowisko";
            dgvHRApp.Columns[5].HeaderText = "Data Zatrudnienia";
            dgvHRApp.Columns[6].HeaderText = "Data Zwolnienia";
            dgvHRApp.Columns[7].HeaderText = "Stawka godzinowa";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEdidEmployee = new AddEditEmployee();
            addEdidEmployee.FormClosing += AddEdidEmployee_FormClosing;
            addEdidEmployee.ShowDialog();
            addEdidEmployee.FormClosing -= AddEdidEmployee_FormClosing;
        }

        private void AddEdidEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshEmployees();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (dgvHRApp.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Zaznacz pracownika, którego dane chcesz edytować.");
            //    return;
            //}

            var addEditEmployee = new AddEditEmployee(Convert.ToInt32(dgvHRApp.SelectedRows[0].Cells[0].Value));
            addEditEmployee.FormClosed += AddEditEmployee_FormClosed1;
            addEditEmployee.ShowDialog();
            addEditEmployee.FormClosed -= AddEditEmployee_FormClosed1;
        }

        private void AddEditEmployee_FormClosed1(object sender, FormClosedEventArgs e)
        {
            RefreshEmployees();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            var selectedEmployee = dgvHRApp.SelectedRows[0];
            var confirmDismiss = MessageBox.Show($"Czy napewno chcesz zwolnić pracownika " +
                $"{(selectedEmployee.Cells[1].Value.ToString() + " " + selectedEmployee.Cells[2].Value.ToString()).Trim()}?", "Zwalnianie pracownika",
                MessageBoxButtons.OKCancel);

            if (confirmDismiss == DialogResult.OK)
            {
                DismimissEmployee(Convert.ToInt32(selectedEmployee.Cells[0].Value));
                RefreshEmployees();
            }
        }

        private void DismimissEmployee(int id)
        {
            var employees = _fileHelper.DeserializeFromFile();
            var employeeToDismiss = employees.Where(e => e.Id == id).FirstOrDefault();
            employees.Remove(employeeToDismiss);
            employeeToDismiss.DismissDate = DateTime.Now.ToShortDateString();
            employeeToDismiss.EmployeeStatusId = 2;
            employees.Add(employeeToDismiss);
            _fileHelper.SerializeToFile(employees);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshEmployees();
        }
    }
}
