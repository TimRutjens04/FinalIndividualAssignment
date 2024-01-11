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
using System.Data.SqlClient;
using System.Drawing.Text;

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

        public Task(int taskId, string taskName, string taskDescription, DateTime timeDue, List<Employee> assignedEmployees, List<Department> assignedDepartments, FinalAssignmentWorkTasks.Classes.TaskStatus status)
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
        public static Task AddTaskToDatabase(Task task)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("server=mssqlstud.fhict.local;" +
                              "database =dbi535094_worktasks;" +
                              "user id =dbi535094_worktasks;" +
                              "password =worktasks;"))
                {
                    conn.Open();

                    string formattedTimeDue = task.TimeDue.ToString("yyyy-MM-dd HH:mm:ss");
                    string insertQuery = @"
                    INSERT INTO Task (TaskId, TaskName, TaskDescription, TimeDue, Status, Department, [Assigned employees])
                    VALUES (@TaskId, @TaskName, @TaskDescription, @TimeDue, @Status, @Department, @AssignedEmployees)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaskId", task.TaskId);
                        cmd.Parameters.AddWithValue("@TaskName", task.TaskName);
                        cmd.Parameters.AddWithValue("@TaskDescription", task.TaskDescription);
                        cmd.Parameters.AddWithValue("@TimeDue", formattedTimeDue);
                        cmd.Parameters.AddWithValue("@Status", task.Status.ToString());
                        cmd.Parameters.AddWithValue("@Department", string.Join(",", task.AssignedDepartments.Select(dep => dep.ToString())));
                        cmd.Parameters.AddWithValue("@AssignedEmployees", string.Join(",", task.AssignedEmployees.Select(emp => emp.ToString())));

                        cmd.ExecuteNonQuery();
                    }
                }

                return task;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);                
            }

        }
    }

}
