using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Model
{
    // Class to hold individual employee information
    internal class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Employee(int empID, string name, int age)
        {
            EmpID = empID;
            Name = name;
            Age = age;
        }
    }

    // Class to manage the collection of employees
    internal class EmployeeList
    {
        // Dictionary to store employee objects with EmpID as the Key
        public Dictionary<int, Employee> Employees { get; set; } = new Dictionary<int, Employee>();

        // Method to add a new employee to the dictionary
        public async Task AddEmployee(int empID, string name, int age)
        {
            // Check if employee with same ID already exists
            if (!Employees.ContainsKey(empID))
            {
                // If not, create new employee and add to dictionary
                var employee = new Employee(empID, name, age);
                Employees.Add(empID, employee);

                await Task.Delay(1000);

                Console.WriteLine($"Employee Added: EmpID={empID}, Name={name}, Age={age}");
            }
            else
            {
                // If employee ID exists already, show a warning
                Console.WriteLine($"Employee with EmpID={empID} already exists.");
            }
        }

        // Method to remove an employee by ID
        public void RemoveEmployee(int empID)
        {
            if (Employees.Remove(empID))
            {
                Console.WriteLine($"Employee ID={empID} removed successfully.");
            }
            else
            {
                Console.WriteLine($"Employee ID={empID} not found.");
            }
        }

        // Method to display all employee records
        public void DisplayEmployees()
        {
            Console.WriteLine("\nEmployee List: ");

            // Loop through the dictionary and print each employee's info
            foreach (var emp in Employees)
            {
                Console.WriteLine($"Employee ID: {emp.Key} , Name:  {emp.Value.Name}, Age:  {emp.Value.Age}");
            }
        }

        // Save method (could be used to saving to file, DB, etc.)
        public async Task SaveAsync()
        {
            Console.WriteLine("\nSaving employee list...");

            await Task.Delay(1000); //Wait a Minute to Save the data

            Console.WriteLine("Save complete.");
        }
    }
}
