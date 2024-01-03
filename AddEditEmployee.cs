using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HRApplication
{
    public partial class AddEditEmployee : Form
    {
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>(Program.FilePath);
        private int _employeeId;
        private Employee _employee;
        private List<EmployeeTypes> _employeeTypes;

        public AddEditEmployee(int id = 0)
        {
            InitializeComponent();
            _employeeId = id;
            _employeeTypes = EmployeeTypesHelper.GetEmployeeType();
            GetEmployeeData();
            InitEmployeeTypeCombobox();
        }

        private void InitEmployeeTypeCombobox()
        {
            cmbEmployeeType.DataSource = _employeeTypes;
            cmbEmployeeType.DisplayMember = "Name";
            cmbEmployeeType.ValueMember = "Id";
        }

        private void GetEmployeeData()
        {
            if (_employeeId != 0)
            {
                Text = "Edycja pracownika";
                var employees = _fileHelper.DeserializeFromFile();
                _employee = employees.FirstOrDefault(e => e.Id == _employeeId);

                if (_employee == null)
                    throw new Exception("Szukany pracownik nie istnieje.");

                FillTextBoxes();
            }
        }
        
        private void FillTextBoxes()
        {
            tbId.Text = _employeeId.ToString();
            tbFirstName.Text = _employee.FirstName;
            tbLastName.Text = _employee.LastName;
            tbBirthday.Text = _employee.Birthday;
            cmbEmployeeType.SelectedItem = _employee.EmployeeType;
            tbEmploymentDate.Text = _employee.EmploymentDate;
            tbDismissDate.Text = _employee.DismissDate;
            tbHourlyRate.Text = _employee.HourlyRate;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();

            if (_employeeId != 0)
                employees.RemoveAll(x => x.Id == _employeeId);

            else
                AssignIdToNewEmployee(employees);

            AddNewEmployeeToList(employees);
            _fileHelper.SerializeToFile(employees);
            Close();
        }

        private void AssignIdToNewEmployee(List<Employee> employees)
        {
            var employeeWithHighestId = employees.OrderByDescending(e => e.Id).FirstOrDefault();
            _employeeId = employeeWithHighestId == null ? 1 : employeeWithHighestId.Id + 1;
        }

        private void AddNewEmployeeToList(List<Employee> employees)
        {
            var employee = new Employee
            {
                Id = _employeeId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Birthday = tbBirthday.Text,
                EmployeeType = cmbEmployeeType.Text,
                EmploymentDate = tbEmploymentDate.Text,
                DismissDate = tbDismissDate.Text,
                HourlyRate = tbHourlyRate.Text,
            };
            if (employee.DismissDate == string.Empty)
                employee.EmployeeStatusId = 1;
            else
                employee.EmployeeStatusId = 2;

            if (employee.FirstName == string.Empty || employee.LastName == string.Empty)
                MessageBox.Show("Nie podano imienia i(lub) nazwiska pracownika. Kliknij OK, po czym uzupełnij dane" +
                    " korzystając z funkcji Edytuj.");

            employees.Add(employee);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
