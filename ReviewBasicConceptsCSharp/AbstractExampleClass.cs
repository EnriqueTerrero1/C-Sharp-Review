using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewBasicConceptsCSharp
{
    public abstract class AbstractExampleClass
    {
        public void PrintToConsole(string text)
        {
            Console.WriteLine(text);
        }

        public abstract void Print(string text);
    }
}
