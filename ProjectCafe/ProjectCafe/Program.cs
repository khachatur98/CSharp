using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress ad = new Adress("Atoyan", "5/1", "Yerevan", "Armenia", 40.1849657, 44.5272205);
            Console.WriteLine(ad);
        }
    }
}
