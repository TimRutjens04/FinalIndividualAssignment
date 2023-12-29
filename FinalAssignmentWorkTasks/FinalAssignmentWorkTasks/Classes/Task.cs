using FinalAssignmentWorkTasks.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

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
        public List<Task> Tasks { get; set; } = new List<Task>();
        [DataMember]
        public List<Employee> AssignedEmployees { get; set; } = new List<Employee>();
        [DataMember]
        public Department Department { get; set; }
        [DataMember]
        public FinalAssignmentWorkTasks.Classes.TaskStatus Status { get; set; }

        public Task() { }

        public Task(int taskId, string taskName, string taskDescription, DateTime timeDue, List<Task> tasks, List<Employee> assignedEmployees, FinalAssignmentWorkTasks.Classes.TaskStatus status)
        {
            TaskId = taskId;
            TaskName = taskName;
            TaskDescription = taskDescription;
            TimeDue = timeDue;
            Tasks = tasks ?? new List<Task>();
            AssignedEmployees = assignedEmployees ?? new List<Employee>();
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
    }

}
