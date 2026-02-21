using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTasks.Task2.Errors
{
    internal class AllReadyExists : Exception
    {
        public AllReadyExists() { }
        public AllReadyExists(string message) : base(message) { }
    }
}
