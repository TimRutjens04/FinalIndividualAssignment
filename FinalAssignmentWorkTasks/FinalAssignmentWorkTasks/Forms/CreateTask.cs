using FinalAssignmentWorkTasks.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private List<Employee> selectedEmployeeList;
        private List<Task> tasks = new List<Task>();
        private int initialTask = 1;
        public CreateTask()
        {
            InitializeComponent();
            monthCalendarDueTime.MinDate = DateTime.Today;
            monthCalendarDueTime.MaxSelectionCount = 1;
            InitializeCheckboxes();
            LoadEmployeeDataFromCsv();
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
            string taskTitle = tbxTaskName.Text;
            string taskDescription = tbxTaskDescription.Text;
            string date = monthCalendarDueTime.SelectionStart.ToShortDateString();
            DateTime taskDate = monthCalendarDueTime.SelectionStart;
            string assignedEmployees = "";
            FinalAssignmentWorkTasks.Classes.TaskStatus statusOnCreate = FinalAssignmentWorkTasks.Classes.TaskStatus.Open;

            foreach (object checkedItem in clbxAssignedEmployees.CheckedItems)
            {
                assignedEmployees += checkedItem.ToString();                
            }
            int taskId = initialTask++;
            Task createdTask = new Task(taskId, taskTitle, taskDescription, taskDate, tasks, selectedEmployeeList, statusOnCreate);
            MessageBox.Show($"Task succesfully created.\nTask ID: {taskId.ToString()}\nDue date: {date}\nAssigned employees: {assignedEmployees}\nTitle: {taskTitle}\nDescription: {taskDescription}");
            tasks.Add(createdTask);
        }

        private void InitializeCheckboxes()
        {
            cbxHR.CheckedChanged += CheckBox_CheckedChanged;
            cbxMarketing.CheckedChanged += CheckBox_CheckedChanged;
            cbxSales.CheckedChanged += CheckBox_CheckedChanged;
            cbxSupport.CheckedChanged += CheckBox_CheckedChanged;
            cbxRD.CheckedChanged += CheckBox_CheckedChanged;
        }

        private void LoadEmployeeDataFromCsv()
        {
            string relativePath = Path.Combine("Resources", "MOCK_EMPLOYEE_DATA.csv");
            selectedEmployeeList = Employee.LoadUserFromCsv(relativePath);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkedDepartments = GetCheckedDepartments();

            var filteredEmployees = selectedEmployeeList.Where(employee => checkedDepartments.Contains(employee.Department)).ToList();
            UpdateCheckedListBox(filteredEmployees);
        }

        private List<Department> GetCheckedDepartments()
        {
            var checkedDepartments = new List<Department>();

            if (cbxHR.Checked) checkedDepartments.Add(Department.Human_Resources);
            if (cbxMarketing.Checked) checkedDepartments.Add(Department.Marketing);
            if (cbxSales.Checked) checkedDepartments.Add(Department.Sales);
            if (cbxSupport.Checked) checkedDepartments.Add(Department.Support);
            if (cbxRD.Checked) checkedDepartments.Add(Department.Research_and_Development);

            return checkedDepartments;
        }

        private void UpdateCheckedListBox(List<Employee> employees)
        {
            // Clear and update the CheckedListBox with the filtered employees
            clbxAssignedEmployees.Items.Clear();
            clbxAssignedEmployees.Items.AddRange(employees.Select(employee => employee.DisplayData).ToArray());
        }
    }
}
