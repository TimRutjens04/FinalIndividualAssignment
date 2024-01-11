using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FinalAssignmentWorkTasks.Forms
{
    public partial class Menu : Form
    {
        SavedUser savedUser = SavedUser.Instance;
        Employee _loggedInEmployee;
        Employee _employee = new Employee();
        public Menu()
        {
            InitializeComponent();
        }
        public Menu(Employee employee) : this()
        {
            ///This sets the labels based on the loggedInEmployee
            _loggedInEmployee = employee;
            if (_loggedInEmployee != null)
            {
                lblUserEmail.Text = $"Email: {_loggedInEmployee.Email}";
                lblUserFirstname.Text = $"First name: {_loggedInEmployee.FirstName}";
                lblUserLastname.Text = $"Last name: {_loggedInEmployee.LastName}";
                lblUserDepartment.Text = $"Department: {_loggedInEmployee.Department.ToString()}";
                if (_loggedInEmployee.Department == Classes.Department.Admin)
                {
                    btnAdminSettings.Visible = true;
                }
                else { btnAdminSettings.Visible = false; }
            }
            else
            {
                lblUserEmail.Text = "Email: Not logged in";
                lblUserFirstname.Text = "First name: Not logged in";
                lblUserLastname.Text = "Last name: Not logged in";
                lblUserDepartment.Text = "Department: Not logged in";
            }
        }

        /// <summary>
        /// Below are all navigation buttons
        /// </summary>

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new TaskDashboard(_loggedInEmployee);
            temp.Show();
        }
        private void btnNewTask_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new CreateTask(_loggedInEmployee);
            temp.Show();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new Settings(_loggedInEmployee);
            temp.Show();
        }
        private void btnAdminSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new SettingsAdmin(_loggedInEmployee);
            temp.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new Login();
            temp.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var temp = new Login();
            temp.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
             
        }
    }
}
