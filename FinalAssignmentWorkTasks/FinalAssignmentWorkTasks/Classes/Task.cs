using FinalAssignmentWorkTasks.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Data;

namespace FinalAssignmentWorkTasks
{
    [DataContract]
    public class Task
    {
        [DataMember]
        public int TaskId { get; set; }
        [DataMember]
        public string TaskName { get; set; }
        [DataMember]
        public string TaskDescription { get; set; }
        [DataMember]
        public DateTime TimeDue { get; set; }
        [DataMember]
        public static List<Task> Tasks { get; set; } = new List<Task>();
        [DataMember]
        public List<Employee> AssignedEmployees { get; set; } = new List<Employee>();
        [DataMember]
        public List<Department> AssignedDepartments { get; set; } = new List<Department>();
        [DataMember]
        public FinalAssignmentWorkTasks.Classes.TaskStatus Status { get; set; }

        public Task() { }

        public Task(int taskId, string taskName, string taskDescription, DateTime timeDue, List<Employee> assignedEmployees,List<Department> assignedDepartments, FinalAssignmentWorkTasks.Classes.TaskStatus status)
        {
            TaskId = taskId;
            TaskName = taskName;
            TaskDescription = taskDescription;
            TimeDue = timeDue;
            AssignedEmployees = assignedEmployees ?? new List<Employee>();
            AssignedDepartments = assignedDepartments ?? new List<Department>();
            Status = status;
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            Tasks.Remove(task);
        }

        public FinalAssignmentWorkTasks.Classes.TaskStatus GetTaskStatus()
        {
            return Status;
        }

        public List<Task> GetTasksByStatus(FinalAssignmentWorkTasks.Classes.TaskStatus status)
        {
            return Tasks.Where(t => t.Status == status).ToList();
        }
        /// <summary>
        /// A method to create a task when selecting one from the TaskDashboard form, which can then be used to be edited again in the CreateTask form
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static Task CreateTaskFromDataRow(DataRow dataRow) 
        {
            if (dataRow == null) 
            {
                throw new ArgumentNullException(nameof(dataRow));
            }

            Task task = new Task
            {
                TaskId = Convert.ToInt32(dataRow["TaskId"]),
                TaskName = Convert.ToString(dataRow["TaskName"]),
                TaskDescription = Convert.ToString(dataRow["TaskDescription"]),
                TimeDue = Convert.ToDateTime(dataRow["TimeDue"]),
                Status = Enum.Parse<FinalAssignmentWorkTasks.Classes.TaskStatus>(Convert.ToString(dataRow["Status"]).Trim()),
                AssignedDepartments = Convert.ToString(dataRow["Department"]).Split(',').Select(dep => Enum.Parse<Department>(dep.Trim())).ToList(),
                AssignedEmployees = Convert.ToString(dataRow["Assigned employees"])
                                  .Split(',')
                                  .Select(empFullName => Employee.fullNameToEmployeeObject.GetValueOrDefault(empFullName.Trim()))
                                  .Where(emp => emp != null)
                                  .ToList(),
            };
            return task;
        }
    }

}
