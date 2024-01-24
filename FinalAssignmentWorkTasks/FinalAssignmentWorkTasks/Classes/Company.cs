using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentWorkTasks
{
    public class Company
    {
        public List<Employee> CompanyEmployees { get; private set; } = new List<Employee>();
        public List<Task> CompanyTasks { get; private set; } = new List<Task>();
        public Company() 
        {
            List<Employee> companyEmployees = CompanyEmployees;
            List<Task> companyTasks = CompanyTasks;
        }
    }
}
