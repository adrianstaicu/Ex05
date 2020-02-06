using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 1;
            for (int n = 2; n < 13; n++)
            {
                suma *= n;
            }
            Console.WriteLine("Factorialul este: " + suma);
            Console.ReadLine();
        }
    }
}
