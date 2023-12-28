using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FinalAssignmentWorkTasks.Forms
{
    public partial class CreateTask : Form
    {
        SavedUser savedUser = SavedUser.Instance;
        Employee _loggedInEmployee;
        private List<Employee> selectedEmployeeList = new List<Employee>();
        public CreateTask()
        {
            InitializeComponent();
            monthCalendarDueTime.MinDate = DateTime.Today;
            monthCalendarDueTime.MaxSelectionCount = 1;
        }

        public CreateTask(Employee employee) : this()
        {
            _loggedInEmployee = employee;
            //lblDepartment.Text = $"Department: {_loggedInEmployee.Department.ToString()}";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new Menu(_loggedInEmployee);
            temp.Show();
        }

        private void CreateTask_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var temp = new Login();
            temp.Show();
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            string date = monthCalendarDueTime.SelectionStart.ToShortDateString();
            MessageBox.Show($"Task succesfully created.\nDue date: {date}\nAssigned employees: blabla");

        }
        
    }
}
