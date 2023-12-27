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
        public string Id { get; private set; } // will be "password" for login
        public string Email { get; private set; } // will be "username" for login
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Department Department { get; private set; }

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
                        if (Enum.TryParse(fields[10].Replace(" ", "_"), true, out Department department))
                        {
                            employees.Add(new Employee()
                            {
                                Email = fields[9],
                                Id = fields[0],
                                FirstName = fields[2],
                                LastName = fields[3],
                                Department = department
                            });
                        }
                        else
                        {
                            //MessageBox.Show("Error retrieving user from file.");
                            MessageBox.Show($"Email {fields[9]}, ID {fields[0]}, Firstname {fields[2]}, Lastname {fields[3]}, Department {department}");
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


    }
}
