using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTasks.Task3.Errors
{
    public class CanNotLessZero : Exception
    {
        public CanNotLessZero() { }
        public CanNotLessZero(string message) : base(message) { }
    }
}
