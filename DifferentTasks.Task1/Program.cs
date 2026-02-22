using DifferentTasks.Task1.Errors;
using DifferentTasks.Task1.Task1Models;

namespace DifferentTasks.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employe = new Employee("Kilan", "Smith", new DateOnly(1993, 5, 20), 4500);
            Employee employe1 = new Employee("N", "Sth", new DateOnly(1997, 2, 5), 4000);
            Employee employe2 = new Employee("M", "S", new DateOnly(1999, 9, 10), 3300);
            Employee employe3 = new Employee("J", "Sm", new DateOnly(1992, 3, 28), 5000);
            Employee employe4 = new Employee("Q", "Smi", new DateOnly(2002, 1, 6), 2500);
            Employee employe5 = new Employee("R", "Smit", new DateOnly(1998, 7, 16), 3500);

            try
            {
                employe.AddEmployee(employe);
                employe.AddEmployee(employe1);
                employe.AddEmployee(employe2);
                employe.AddEmployee(employe3);
                employe.AddEmployee(employe4);
                employe.AddEmployee(employe5);

                employe.SortEmployeesBySalary();

                employe.GetSalaryByDate(new DateOnly(1995, 1, 1), new DateOnly(2000, 12, 31));
            }
            catch (NotNullOrEmpty ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
