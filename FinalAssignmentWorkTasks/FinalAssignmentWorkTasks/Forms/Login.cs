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
            string username = tbxUsername.Text.Trim();
            string password = tbxPassword.Text.Trim();
            Department department;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) 
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            bool rememberMe = cbxRememberMe.Checked; //doesnt work yet

            SavedUser user = SavedUser.Instance;

            if (SavedUser.Employees.Count == 0)
            {
                string relativePath = Path.Combine("Resources", "MOCK_EMPLOYEE_DATA.csv");
                SavedUser.Employees = Employee.LoadUserFromCsv(relativePath);
            }

            if (user.EmployeeLogin(username, password, out department))
            {
                Employee savedEmployee = Employee.GetUserFromCredentials(SavedUser.Employees, username, password);

                user.SetSavedEmployee(savedEmployee);

                MessageBox.Show(username);
                this.Hide();
                var temp = new Menu(savedEmployee);
                temp.Show();
            }
            else
            {
                MessageBox.Show($"Error logging in {username}, {password}, {department}");
            }
        }
    }
}