using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGameA
{
    public class ConsolePrint : IPrinting
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }

    }
}
