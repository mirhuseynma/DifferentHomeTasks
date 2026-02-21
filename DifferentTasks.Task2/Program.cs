using DifferentTasks.Task2.Errors;
using DifferentTasks.Task2.Task2Classes;

namespace DifferentTasks.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // rooms
            Room room1 = new Room("Deluxe", 150.0, 2);
            Room room2 = new Room("Suite", 250.0, 4);
            
            // hotels
            Hotel hotel = new Hotel("Grand Hotel");

            try
            {
                hotel.AddRooms(room1);
                hotel.AddRooms(room2);
                hotel.ShowRooms();
                Console.WriteLine(hotel[1].ShowInfo());
                hotel.ReserveRoom(1);
                hotel.ReserveRoom(2);

                hotel.ShowRooms();
                
            }
            catch (AllReadyExists ex) 
            {
                Console.WriteLine($"Error!  {ex}");
            }
            catch (NotNullOrEmpty ex)
            {
                Console.WriteLine($"Error!  {ex.Message}");
            }
            catch (NotAvailableException ex)
            {
                Console.WriteLine($"Error!  {ex.Message}");
            }
        }
    }
}
