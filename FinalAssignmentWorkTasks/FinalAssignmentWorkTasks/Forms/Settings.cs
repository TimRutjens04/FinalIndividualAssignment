using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignmentWorkTasks.Forms
{
    /// <summary>
    /// Will eventually allow all kinds of customization, think of dark mode and password changes
    /// </summary>
    public partial class Settings : Form
    {
        SavedUser savedUser = SavedUser.Instance;
        Employee _loggedInEmployee;
        public Settings()
        {
            InitializeComponent();
            InitializeLabels();
        }
        public Settings(Employee employee) : this()
        {
            _loggedInEmployee = employee;
        }
        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var temp = new Login();
            temp.Show();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new Menu(_loggedInEmployee);
            temp.Show();
        }
        
        public void InitializeLabels() 
        {
            string relativePath = Path.Combine("Resources", "MOCK_EMPLOYEE_DATA.csv");
            List<Employee> allEmployees = Employee.LoadUserFromCsvForSettings(relativePath);
            if(allEmployees == null) 
            {
                MessageBox.Show("Error parsing data from CSV");
                return;
            }

            Employee loggedInEmployee = allEmployees.FirstOrDefault(emp => emp.Id == SavedUser.Instance.savedEmployee.Id);
            if(loggedInEmployee == null) 
            {
                MessageBox.Show("Error finding logged in user");
                return;
            }

            lblFirstName.Text = $"First name: {loggedInEmployee.FirstName}";
            lblLastName.Text = $"Last name: {loggedInEmployee.LastName}";
            lblEmail.Text = $"Email: {loggedInEmployee.Email}";
            lblGender.Text = $"Gender: {loggedInEmployee.Gender}";
            lblStreetName.Text = $"Street name: {loggedInEmployee.StreetName}";
            lblStreetNumber.Text = $"Street number: {loggedInEmployee.StreetNumber}";
            lblZipcode.Text = $"Zip code: {loggedInEmployee.Zipcode}";
            lblCity.Text = $"City: {loggedInEmployee.City}";
        }
    }
}
