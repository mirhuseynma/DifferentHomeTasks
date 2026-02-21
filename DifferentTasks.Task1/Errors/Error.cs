using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTasks.Task1.Errors
{
    public class Error : Exception
    {
        public Error() { }

        public Error(string message) : base(message) { }
        public Error(string message, Exception inner) : base(message, inner) { }
    }
}
