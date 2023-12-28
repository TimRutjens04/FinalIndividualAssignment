using FinalAssignmentWorkTasks.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentWorkTasks
{
    public class Employee
    {
        public string Id { get; set; } // will be "password" for login
        public string Email { get; set; } // will be "username" for login
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
        public string DisplayData => $"{FirstName} {LastName}\nDepartment: {Department}";

        public Employee()
        {

        }
        public Employee(string email, string id, string firstName, string lastName, Department department)
        {
            Email = email;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }
        public static List<Employee> LoadUserFromCsv(string filePath)
        {
            List<Employee> employees = new List<Employee>();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (fields.Length == 11)
                    {
                        if (Enum.TryParse(fields[10], out Department department))
                        {
                            Employee newEmployee = new Employee()
                            {
                                Email = fields[9],
                                Id = fields[0],
                                FirstName = fields[2],
                                LastName = fields[3],
                                Department = department
                            };
                            employees.Add(newEmployee);
                        }
                    }
                }
            }

            return employees;
        }

        public static Employee GetUserFromCredentials(List<Employee> employees, string email, string id)
        {
            return employees.FirstOrDefault(user =>
                user.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                user.Id == id);
        }
        public static Department ParseDepartment(string departmentString)
        { 
            switch (departmentString.Trim())
            {
                case "Human Resources":
                    return Department.Human_Resources;
                case "Sales":
                    return Department.Sales;
                case "Marketing":
                    return Department.Marketing;
                case "Support":
                    return Department.Support;
                case "Research and Development":
                    return Department.Research_and_Development;
                default:
                    throw new ArgumentException($"Invalid department: {departmentString}");
            }
        }

    }
}
