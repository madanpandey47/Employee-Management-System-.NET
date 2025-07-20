using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            EmployeeList obj = new EmployeeList();
            Console.WriteLine("\nAdding Employees...");

            await obj.AddEmployee(1, "Madan Pandey", 20);
            await obj.AddEmployee(2, "Aarpan Parajuli", 19);
            await obj.AddEmployee(3, "Mohit Paudel", 21);
            await obj.AddEmployee(4, "Roshan K.C.", 18);


            //Display the Employee

            obj.DisplayEmployees();
            await obj.SaveAsync();

            //Remove An Employee

            obj.RemoveEmployee(2);
            obj.RemoveEmployee(3);
            obj.DisplayEmployees();


            await obj.SaveAsync();
            Console.WriteLine("\nSuccessfully saved the Employee list.");
            Console.ReadLine();

        }
    }
}