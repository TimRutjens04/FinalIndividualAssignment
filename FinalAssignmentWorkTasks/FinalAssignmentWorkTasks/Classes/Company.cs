using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentWorkTasks
{
    /// <summary>
    /// Will be used to filter the list of assigned tasks based on the logged in employee by either their department or their own assigned tasks.
    /// Will also be used to allow the admin to see all created tasks.
    /// </summary>
    public class Company
    {
        public static List<Employee> CompanyEmployees;
        public static List<Task> CompanyTasks;
        public Company() { }
    }
}
