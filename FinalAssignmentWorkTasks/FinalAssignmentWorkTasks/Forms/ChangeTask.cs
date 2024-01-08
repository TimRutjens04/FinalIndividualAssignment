using System;
using System.CodeDom.Compiler;
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
    public partial class ChangeTask : Form
    {
        Employee _loggedInEmployee;
        Task _selectedTask;

        public ChangeTask()
        {
            InitializeComponent();
        }
        public ChangeTask(Employee employee, Task task) : this()
        {
            _loggedInEmployee = employee;
            _selectedTask = task;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new Menu(_loggedInEmployee);
            temp.Show();
        }
        private void ChangeTask_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var temp = new Login();
            temp.Show();
        }
    }
}
