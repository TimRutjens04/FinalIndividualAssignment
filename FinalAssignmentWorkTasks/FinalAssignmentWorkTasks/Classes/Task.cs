using FinalAssignmentWorkTasks.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentWorkTasks
{
    public class Task
    {
        public int TaskId { get; private set; }
        public string TaskName { get; private set; }
        public string TaskDescription { get; private set; }
        public DateTime TimeDue { get; private set; }
        public List<Task> Tasks { get; private set; } = new List<Task>();
        public List<Employee> AssignedEmployees { get; private set; } = new List<Employee>();
        public Department Department { get; private set; }
        public FinalAssignmentWorkTasks.Classes.TaskStatus Status { get; private set; }

        public Task() { }

        public Task(int taskId, string taskName, string taskDescription, DateTime timeDue, List<Task> tasks, List<Employee> assignedEmployees, Department department, FinalAssignmentWorkTasks.Classes.TaskStatus status)
        {
            TaskId = taskId;
            TaskName = taskName;
            TaskDescription = taskDescription;
            TimeDue = timeDue;
            Tasks = tasks ?? new List<Task>();
            AssignedEmployees = assignedEmployees ?? new List<Employee>();
            Department = department;
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
