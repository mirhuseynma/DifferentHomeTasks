using DifferentTasks.Task2.Errors;

namespace DifferentTasks.Task2.Task2Classes
{
    public class Hotel
    {
        private static Room[] rooms = [];
        public string HotelName { get; set; }

        public Hotel(string hotelName)
        {
            HotelName = hotelName;
        }



        public void AddRooms(Room room)
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i].Id == room.Id)
                    throw new AllReadyExists("Room with the same ID already exists.");
                if (string.IsNullOrEmpty(room.Name))
                    throw new NotNullOrEmpty("Room name cannot be null.");
            }
            Array.Resize(ref rooms, rooms.Length + 1);
            rooms[^1] = room;
        }

        public void ReserveRoom(int roomId)
        {
            foreach (Room room in rooms)
            {
                if (room.Id == roomId)
                {
                    if (!room.IsAvailable)
                        throw new NotAvailableException("Room is already reserved.");
                    room.IsAvailable = false;
                    
                Console.WriteLine($"{roomId} nomreli otaq artiq musteri istifadesine verildi");
                }
            }

        }

        public void ShowRooms()
        {
            foreach (var room in rooms)
                Console.WriteLine($"Hotel: {HotelName}, " + room.ShowInfo());
        }

        //indexer
        public Room this[int index] 
        {  
            get { return rooms[index]; }  
            set { rooms[index] = value; }    
        }
    }
}
