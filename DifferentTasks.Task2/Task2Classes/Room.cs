using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTasks.Task2.Task2Classes
{
    public class Room
    {
        private static int ID;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }   
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; }
        
        public Room(string name, double price, int capacity)
        {
            ID++;
            Id = ID;
            Name = name;
            Price = price;
            Capacity = capacity;
            IsAvailable = true; 
        }

        public string ShowInfo()
        {
            return $"ID: {Id}, Name: {Name}, Price: {Price}, Capacity: {Capacity}, IsAvailable: {IsAvailable}";
        }

        override public string ToString()
        {
            return ShowInfo();
        }
    }
}
