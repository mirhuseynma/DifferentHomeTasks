using DifferentTasks.Task3.Errors;
using DifferentTasks.Task3.Task3Models;

namespace DifferentTasks.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Weapon weapon = new Weapon("AK-74",38,Enums.FireMode.Automatic);
                weapon.GetAllMethods();
            }
            catch (CanNotLessZero ex)
            {             
                Console.WriteLine(ex.Message);
            }
            catch (CanNotGreater ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TheEnd ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
            


            }
    }
}
