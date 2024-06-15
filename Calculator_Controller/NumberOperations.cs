using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Controller
{
    public class NumberOperations
    {
        public string InterpetNumber(string button, string previous)
        {
            if (previous == "0")
            {
                return button;
            }
            else
            {
                return previous + button;
            }
        }
    }
}
