using FinalAssignmentWorkTasks.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FinalAssignmentWorkTasks.Forms
{
    public partial class TaskDashboard : Form
    {
        SavedUser savedUser = SavedUser.Instance;
        Employee _loggedInEmployee;
        Task _selectedTask;
        private static List<Task> Tasks = new List<Task>();
        private XmlSerializer serializer = new XmlSerializer(typeof(Task));
        private DataTable tasksDataTable = new DataTable();

        public TaskDashboard()
        {
            InitializeComponent();
            CreateTask createTaskForm = new CreateTask();
            if (createTaskForm != null)
            {
                Tasks = CreateTask.GetTasks;
            }
            if (dataGridViewTasks.SelectedRows == null)
            {
                btnChangeSelectedTask.Enabled = false;
            }
        }

        public TaskDashboard(Employee employee) : this()
        {
            _loggedInEmployee = employee;
            InitializeCheckboxes();
            if (_loggedInEmployee != null)
            {
                lblUserEmail.Text = $"Email: {_loggedInEmployee.Email}";
                lblUserFirstname.Text = $"First name: {_loggedInEmployee.FirstName}";
                lblUserLastname.Text = $"Last name: {_loggedInEmployee.LastName}";
                lblUserDepartment.Text = $"Department: {_loggedInEmployee.Department.ToString()}";
            }
            else
            {
                lblUserEmail.Text = "Email: Not logged in";
                lblUserFirstname.Text = "First name: Not logged in";
                lblUserLastname.Text = "Last name: Not logged in";
                lblUserDepartment.Text = "Department: Not logged in";
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new Menu(_loggedInEmployee);
            temp.Show();
        }
        private void btnChangeSelectedTask_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                DataRow selectedRow = ((DataRowView)dataGridViewTasks.SelectedRows[0].DataBoundItem).Row;
                _selectedTask = Task.CreateTaskFromDataRow(selectedRow);
                if (_selectedTask != null)
                {
                    this.Hide();
                    var temp = new CreateTask(_selectedTask, _loggedInEmployee);
                    temp.Show();
                }
            }
            else { MessageBox.Show("Please select a task"); }
        }

        private void TaskDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var temp = new Login();
            temp.Show();
        }

        private void TaskDashboard_Load(object sender, EventArgs e)
        {
            Tasks.Clear();
            Tasks.AddRange(LoadTasksFromXmlFiles());
            tasksDataTable = ConvertToDataTable(Tasks);
            dataGridViewTasks.DataSource = tasksDataTable;
        }

        private List<Task> LoadTasksFromXmlFiles()
        {
            List<Task> tasks = new List<Task>();
            string projectRoot = Path.Combine(Environment.CurrentDirectory, "../../../");
            string tasksFolderPath = Path.Combine(projectRoot, "Tasks");

            if (Directory.Exists(tasksFolderPath))
            {
                string[] xmlFiles = Directory.GetFiles(tasksFolderPath, "*.xml");

                foreach (string xmlFile in xmlFiles)
                {
                    using (FileStream fs = new FileStream(xmlFile, FileMode.Open))
                    {
                        try
                        {
                            Task task = (Task)serializer.Deserialize(fs);
                            tasks.Add(task);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading task from {xmlFile}: {ex.Message}");
                        }
                    }
                }
            }
            return tasks;
        }

        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRowView selectedDataRowView = dataGridViewTasks.Rows[e.RowIndex].DataBoundItem as DataRowView;

                if (selectedDataRowView != null)
                {
                    DataRow selectedDataRow = selectedDataRowView.Row;

                    int taskId = Convert.ToInt32(selectedDataRow["TaskId"]);
                    Task selectedTask = Tasks.FirstOrDefault(task => task.TaskId == taskId);

                    if (selectedTask != null)
                    {
                        string taskTitle = selectedTask.TaskName;
                        string taskDescription = selectedTask.TaskDescription;
                        string taskTimeDue = selectedTask.TimeDue.ToString();
                        string taskStatus = selectedTask.Status.ToString();

                        string taskAssignedEmployees = string.Join(", ", selectedTask.AssignedEmployees.Select(employee => employee.FullName));
                        string taskAssignedDepartments = string.Join(", ", selectedTask.AssignedDepartments);

                        MessageBox.Show($"Selected task:\nID: {taskId}\nTitle: {taskTitle}\nDescription: {taskDescription}\nTime due: {taskTimeDue}\nStatus: {taskStatus}\nAssigned employees: {taskAssignedEmployees}\nAssigned departments: {taskAssignedDepartments}");
                    }
                    else
                    {
                        MessageBox.Show($"Task not found.");
                    }
                }
                else
                {
                    MessageBox.Show($"There is an error with the task selection.\nPlease try again.");
                }
            }
        }

        private DataTable ConvertToDataTable(List<Task> tasks)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("TaskId", typeof(int));
            dataTable.Columns.Add("TaskName", typeof(string));
            dataTable.Columns.Add("TaskDescription", typeof(string));
            dataTable.Columns.Add("TimeDue", typeof(DateTime));
            dataTable.Columns.Add("Status", typeof(FinalAssignmentWorkTasks.Classes.TaskStatus));
            dataTable.Columns.Add("Department", typeof(string));
            dataTable.Columns.Add("Assigned employees", typeof(string));

            foreach (var task in tasks)
            {
                string assignedDepartments = string.Join(", ", task.AssignedDepartments.Select(dep => dep.ToString()));
                string assignedEmployees = string.Join(", ", task.AssignedEmployees.Select(emp => emp.ToString()));
                dataTable.Rows.Add(task.TaskId, task.TaskName, task.TaskDescription, task.TimeDue, task.Status, assignedDepartments, assignedEmployees);
            }

            return dataTable;
        }

        private void tbxTitle_TextChanged(object sender, EventArgs e)
        {
            string filterField = "TaskName";
            tasksDataTable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, tbxTitle.Text);
        }

        private void tbxId_TextChanged(object sender, EventArgs e)
        {
            string filterField = "TaskId";
            tasksDataTable.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", filterField, tbxId.Text);
        }
        private void InitializeCheckboxes()
        {
            cbxDepartmentHr.CheckedChanged += CheckBox_CheckedChanged;
            cbxDepartmentMarketing.CheckedChanged += CheckBox_CheckedChanged;
            cbxDepartmentSales.CheckedChanged += CheckBox_CheckedChanged;
            cbxDepartmentSupport.CheckedChanged += CheckBox_CheckedChanged;
            cbxDepartmentRd.CheckedChanged += CheckBox_CheckedChanged;

            cbxStatusOpen.CheckedChanged += CheckBox_CheckedChanged;
            cbxStatusInProgress.CheckedChanged += CheckBox_CheckedChanged;
            cbxStatusCompleted.CheckedChanged += CheckBox_CheckedChanged;
            cbxStatusBlocked.CheckedChanged += CheckBox_CheckedChanged;
            cbxStatusCancelled.CheckedChanged += CheckBox_CheckedChanged;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkedDepartments = GetCheckedDepartments();
            var checkedStatuses = GetCheckedStatuses();

            //MessageBox.Show("Checked Departments: " + string.Join(", ", checkedDepartments));
            //MessageBox.Show("Checked Statuses: " + string.Join(", ", checkedStatuses));

            var filteredTasks = tasksDataTable.AsEnumerable()
                .Where(task =>
                {
                    var departmentValues = task.Field<string>("Department").Split(',').Select(dep => dep.Trim());
                    var statusValue = task.Field<int>("Status").ToString().Replace("_", ""); //System.InvalidCastException: 'Unable to cast object of type 'System.Int32' to type 'System.String'.' so made it int and then used ToString()

                    //MessageBox.Show($"Checking Task: Department={string.Join(", ", departmentValues)}, Status={statusValue}");

                    return departmentValues.Any(dep => checkedDepartments.Contains(Enum.Parse<Department>(dep))) &&
                           checkedStatuses.Contains(Enum.Parse<FinalAssignmentWorkTasks.Classes.TaskStatus>(statusValue));
                })
                .ToList();

            if (filteredTasks.Any())
            {
                var filteredDataTable = filteredTasks.CopyToDataTable();
                UpdateFilteredTasks(filteredDataTable);
                MessageBox.Show($"Does it even enter this block?\nFilteredTask: {filteredTasks.ToString()}");
            }
            else
            {
                UpdateFilteredTasks(new DataTable());
                //MessageBox.Show("No matching rows found.");
            }
        }


        private List<Department> GetCheckedDepartments()
        {
            var checkedDepartments = new List<Department>();

            if (cbxDepartmentHr.Checked) checkedDepartments.Add(Department.Human_Resources);
            if (cbxDepartmentMarketing.Checked) checkedDepartments.Add(Department.Marketing);
            if (cbxDepartmentSales.Checked) checkedDepartments.Add(Department.Sales);
            if (cbxDepartmentSupport.Checked) checkedDepartments.Add(Department.Support);
            if (cbxDepartmentRd.Checked) checkedDepartments.Add(Department.Research_and_Development);

            return checkedDepartments;
        }

        private List<FinalAssignmentWorkTasks.Classes.TaskStatus> GetCheckedStatuses()
        {
            var checkedStatuses = new List<FinalAssignmentWorkTasks.Classes.TaskStatus>();

            if (cbxStatusOpen.Checked) checkedStatuses.Add(FinalAssignmentWorkTasks.Classes.TaskStatus.Open);
            if (cbxStatusInProgress.Checked) checkedStatuses.Add(FinalAssignmentWorkTasks.Classes.TaskStatus.In_Progress);
            if (cbxStatusCompleted.Checked) checkedStatuses.Add(FinalAssignmentWorkTasks.Classes.TaskStatus.Completed);
            if (cbxStatusBlocked.Checked) checkedStatuses.Add(FinalAssignmentWorkTasks.Classes.TaskStatus.Blocked);
            if (cbxStatusCancelled.Checked) checkedStatuses.Add(FinalAssignmentWorkTasks.Classes.TaskStatus.Cancelled);

            return checkedStatuses;
        }
        private void UpdateFilteredTasks(DataTable filteredTasks)
        {
            dataGridViewTasks.DataSource = filteredTasks;
        }
    }
}
