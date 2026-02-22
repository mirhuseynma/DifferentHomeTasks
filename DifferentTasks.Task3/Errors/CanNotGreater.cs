using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTasks.Task3.Errors
{
    public class CanNotGreater : Exception
    {
        public CanNotGreater() { }
        public CanNotGreater(string message) : base(message) { }
    }
}
