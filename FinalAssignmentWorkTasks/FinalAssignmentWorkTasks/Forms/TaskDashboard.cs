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
        private static List<Task> Tasks = new List<Task>();
        private XmlSerializer serializer = new XmlSerializer(typeof(Task));

        public TaskDashboard()
        {
            InitializeComponent();
            CreateTask createTaskForm = new CreateTask();
            if (createTaskForm != null)
            {
                Tasks = CreateTask.GetTasks;
            }
        }

        public TaskDashboard(Employee employee) : this()
        {
            _loggedInEmployee = employee;
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
            dataGridViewTasks.DataSource = Tasks;
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
                Task selectedTask = dataGridViewTasks.Rows[e.RowIndex].DataBoundItem as Task;

                if (selectedTask != null)
                {
                    string taskId = selectedTask.TaskId.ToString();
                    string taskTitle = selectedTask.TaskName;
                    string taskDescription = selectedTask.TaskDescription;
                    string taskTimeDue = selectedTask.TimeDue.ToString();
                    string taskStatus = selectedTask.Status.ToString();

                    string taskAssignedEmployees = string.Join(", ", selectedTask.AssignedEmployees.Select(employee => employee.FullName));
                    string taskAssignedDepartments = string.Join(", ", selectedTask.AssignedDepartments);

                    MessageBox.Show($"Selected task:\nID: {taskId}\nTitle: {taskTitle}\nDescription: {taskDescription}\nTime due: {taskTimeDue}\nStatus: {taskStatus}\nAssigned employees: {taskAssignedEmployees}\nAssigned departments: {taskAssignedDepartments}");
                }
                else { MessageBox.Show($"There is an error with the task selection.\nPlease try again.");}
            }
        }
    }
}
