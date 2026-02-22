using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTasks.Task1.Errors
{
    public class NotNullOrEmpty : Exception
    {
        public NotNullOrEmpty() { }

        public NotNullOrEmpty(string message) : base(message) { }
        
    }
}
