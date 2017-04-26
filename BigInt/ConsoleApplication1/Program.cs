using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
        }
        static void Print()
        {
            string[] enumNames = Enum.GetNames(typeof(EnumDay));
            //DayOfWeek day1 = DayOfWeek.Monday;
            // Print(day1);
            foreach (var a in enumNames)
            {
                Console.WriteLine(a);
            }
        }
    }
}
