﻿using FinalAssignmentWorkTasks.Classes;
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
        public static int GetNextId(int id) 
        {
            while (Company.CompanyTasks.Find(task => task.TaskId == id) != null) id++;
            return id;
        }
    }

}
