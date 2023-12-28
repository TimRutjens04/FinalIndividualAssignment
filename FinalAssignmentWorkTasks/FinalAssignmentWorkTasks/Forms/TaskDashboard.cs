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
    public partial class TaskDashboard : Form
    {
        SavedUser savedUser = SavedUser.Instance;
        Employee _loggedInEmployee;
        public TaskDashboard()
        {
            InitializeComponent();
        }

        public TaskDashboard(Employee employee) : this()
        {
            _loggedInEmployee = employee;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new Menu(_loggedInEmployee);
            temp.Show();
        }
    }
}
