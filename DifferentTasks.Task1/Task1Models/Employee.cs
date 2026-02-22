using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DifferentTasks.Task1.Errors;

namespace DifferentTasks.Task1.Task1Models
{
    public class Employee
    {
        private static Employee[] employees = [];
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly Birthday { get; set; }
        public double Salary { get; set; }


        public Employee(string name, string surname, DateOnly birthday, double salary)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Salary = salary;
        }

        public void AddEmployee(Employee employee)
        {
            foreach (var emp in employees)
            {
                if (string.IsNullOrEmpty(emp.Name) || string.IsNullOrEmpty(emp.Surname))
                    throw new NotNullOrEmpty("Employee with null name and surname cannot be added.");
            }
            Array.Resize(ref employees, employees.Length + 1);
            employees[^1] = employee;        
        }

        public void SortEmployeesBySalary()
        {
            Array.Sort(employees, (emp1, emp2) => emp1.Salary.CompareTo(emp2.Salary));
            foreach (var emp in employees)
            {
                if (emp.Name == null && emp.Surname == null)
                {
                    throw new NotNullOrEmpty("Employee with null name and surname cannot be added.");
                }
                else
                {
                    Console.WriteLine($"Employee: {emp.Name} {emp.Surname}, Salary: {emp.Salary}");
                }
            }
            Console.WriteLine("\n");
        }

        public void GetSalaryByDate(DateOnly dateOne, DateOnly dateTwo)
        {
            Array.Sort(employees, (emp1, emp2) => emp1.Salary.CompareTo(emp2.Salary));
            foreach (var employee in employees)
            {
                if (employee.Birthday >= dateOne && employee.Birthday <= dateTwo && employee.Salary > 2000)
                {
                    Console.WriteLine($"Employee: {employee.Name} {employee.Surname}, Salary: {employee.Salary}");
                }
            }
            Console.WriteLine("\n");
        }


    }
}
