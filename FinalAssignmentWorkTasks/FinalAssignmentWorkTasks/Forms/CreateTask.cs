﻿using FinalAssignmentWorkTasks.Classes;
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
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FinalAssignmentWorkTasks.Forms
{
    public partial class CreateTask : Form
    {
        bool _showAdditionalControls;
        Task _task;
        SavedUser savedUser = SavedUser.Instance;
        Employee _loggedInEmployee;
        private List<Employee> selectedEmployeeList;
        private List<Department> selectedDepartmentList;
        private static List<Task> tasks = new List<Task>(); 
        public static List<Task> GetTasks
        { 
            get { return tasks; }
        }
        private int initialTask = 1;
        private XmlSerializer serializer = new XmlSerializer(typeof(Task));
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
        }
        public CreateTask(Task task, bool showAdditionalControls = true) : this()
        {
            //_loggedInEmployee = employee;
            _task = task;
            _showAdditionalControls = showAdditionalControls;
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
        private void LoadEmployeeDataFromCsv()
        {
            string relativePath = Path.Combine("Resources", "MOCK_EMPLOYEE_DATA.csv");
            selectedEmployeeList = Employee.LoadUserFromCsv(relativePath, out List<Department> departments);
            selectedDepartmentList = departments;

            foreach (var employee in selectedEmployeeList) 
            {
                Employee.displayDataToEmployeeObject.Add(employee.DisplayData, employee);
            }
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

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            selectedEmployeeList.Clear();
            selectedDepartmentList.Clear();
            string taskTitle = tbxTaskName.Text;
            string taskDescription = tbxTaskDescription.Text;
            string date = monthCalendarDueTime.SelectionStart.ToShortDateString();
            List<Department> checkedDepartments = GetCheckedDepartments();
            DateTime taskDate = monthCalendarDueTime.SelectionStart;
            string assignedEmployees = "";
            FinalAssignmentWorkTasks.Classes.TaskStatus statusOnCreate = FinalAssignmentWorkTasks.Classes.TaskStatus.Open;

            foreach (object checkedItem in clbxAssignedEmployees.CheckedItems)
            {  
                if (checkedItem is string employeeDisplayData && Employee.displayDataToEmployeeObject.TryGetValue(employeeDisplayData, out var employee)) //need fix this
                {
                    selectedEmployeeList.Add(employee);
                    assignedEmployees += employee.DisplayData + "\n";
                }
            }

            int taskId = TaskID.GetNextID();
            Task createdTask = new Task(taskId, taskTitle, taskDescription, taskDate, selectedEmployeeList, checkedDepartments, statusOnCreate);
            MessageBox.Show($"Task succesfully created.\nTask ID: {taskId.ToString()}\nDue date: {date}\nAssigned employees: {assignedEmployees}\nTitle: {taskTitle}\nDescription: {taskDescription}");

            tasks.Add(createdTask);

            string projectRoot = Path.Combine(Environment.CurrentDirectory, "../../../");
            string directoryPath = Path.Combine(projectRoot, "Tasks");
            string fileName = $"{taskTitle}_{taskId.ToString()}.xml";
            string fullPath = Path.Combine(directoryPath, fileName);

            using (FileStream fs = new(fullPath, FileMode.Create, FileAccess.Write))
            {
                try 
                {
                    serializer.Serialize(fs, createdTask);
                    MessageBox.Show($"Task succesfully saved at {fullPath}");
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Error saving data \n" + ex.Message);
                }
            }
        }

        private void InitializeCheckboxes()
        {
            cbxHR.CheckedChanged += CheckBox_CheckedChanged;
            cbxMarketing.CheckedChanged += CheckBox_CheckedChanged;
            cbxSales.CheckedChanged += CheckBox_CheckedChanged;
            cbxSupport.CheckedChanged += CheckBox_CheckedChanged;
            cbxRD.CheckedChanged += CheckBox_CheckedChanged;
        }        

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkedDepartments = GetCheckedDepartments();

            var filteredEmployees = selectedEmployeeList.Where(employee => checkedDepartments.Contains(employee.Department)).ToList();
            UpdateCheckedListBox(filteredEmployees);
        }

        

        private void UpdateCheckedListBox(List<Employee> employees)
        {
            clbxAssignedEmployees.Items.Clear();
            clbxAssignedEmployees.Items.AddRange(employees.Select(employee => employee.DisplayData).ToArray());
        }
    }
}
