using FinalAssignmentWorkTasks.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentWorkTasks
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public string Id { get; set; } // will be "password" for login
        [DataMember]
        public string Email { get; set; } // will be "username" for login
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public Department Department { get; set; }
        [DataMember]
        public string DisplayData => $"{FirstName} {LastName} (Department: {Department})\n";
        [DataMember]
        public string FullName => $"{FirstName} {LastName}";
        [DataMember]
        public static Dictionary<string, Employee> displayDataToEmployeeObject = new Dictionary<string, Employee>();
        [DataMember]
        public static Dictionary<string, Employee> fullNameToEmployeeObject = new Dictionary<string, Employee>();
        [DataMember]
        public static HashSet<string> addedEmployees = new HashSet<string>(); //to keep track of added employees so there are no errors resulting from an attempt to add duplicates
        [DataMember]
        public List<Task> AssignedTasks { get; set; } = new List<Task>(); //to display tasks assigned to user
        //Might use a .Where() in the Tasks list instead of assigning tasks to the user object

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
        public override string ToString()
        {
            return FullName;
        }
        /// <summary>
        /// A method for loading the users from the given MOCK_EMPLOYEE_DATA.csv file, and passing a department list out since this is needed for Task creation.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="departments"></param>
        /// <returns></returns>
        public static List<Employee> LoadUserFromCsv(string filePath, out List<Department> departments)
        {
            List<Employee> employees = new List<Employee>();
            departments = new List<Department>();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (fields.Length == 11)
                    {
                        string departmentString = fields[10].Replace(" ", "_");
                        if (Enum.TryParse(departmentString, out Department department))
                        {
                            departments.Add(department);
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
        /// <summary>
        /// Almost the same method, however this one was needed for logins since departments haven't been "set" there yet.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
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
                        string departmentString = fields[10].Replace(" ", "_");
                        if (Enum.TryParse(departmentString, out Department department))
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
        /// <summary>
        /// This method gets the user from the list of users/employees and allows for usage of the logged-in employee object.
        /// </summary>
        /// <param name="employees"></param>
        /// <param name="email"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Employee GetUserFromCredentials(List<Employee> employees, string email, string id)
        {
            return employees.FirstOrDefault(user =>
                user.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                user.Id == id);
        }
    }
}
