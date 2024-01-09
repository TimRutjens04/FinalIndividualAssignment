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
        }
        public Settings(Employee employee) : this()
        {
            _loggedInEmployee = employee;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new Menu(_loggedInEmployee);
            temp.Show();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var temp = new Login();
            temp.Show();
        }
    }
}
