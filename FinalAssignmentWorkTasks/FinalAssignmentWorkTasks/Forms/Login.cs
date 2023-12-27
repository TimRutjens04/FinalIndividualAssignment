using FinalAssignmentWorkTasks.Classes;
using FinalAssignmentWorkTasks.Forms;

namespace FinalAssignmentWorkTasks
{
    public partial class Login : Form
    {
        private Employee employee;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ///
            /// Add login logic later
            ///
            string username = tbxUsername.Text.Trim();
            string password = tbxPassword.Text.Trim();
            Department department;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) 
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            bool rememberMe = cbxRememberMe.Checked; //doesnt work yet

            SavedUser user = new SavedUser("..\\MOCK_EMPLOYEE_DATA.csv");
            List<Employee> employees = user.employees;

            if (user.EmployeeLogin(username, password, out department))
            {
                Employee savedEmployee = Employee.GetUserFromCredentials(employees, username, password);
                MessageBox.Show(username);
                employees.Add(savedEmployee);
                
                this.Hide();
                var temp = new Menu(savedEmployee);
                temp.Show();
            }
            else { MessageBox.Show("Error logging in");}

            
        }
    }
}