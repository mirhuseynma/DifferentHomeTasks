using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTasks.Task3.Errors
{
    public class TheEnd : Exception
    {
        public TheEnd() { }
        public TheEnd(string message) : base(message) { }
    }
}
