using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f_max
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, max;

            Console.Write("Podaj pierwszą wartość: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj drugą wartość: ");
            b = Convert.ToInt32(Console.ReadLine());

            max = a > b ? a : b;

            Console.WriteLine("Wartość maksymalna wynosi: ¬{0}.", max);
            Console.ReadKey();


        }
    }
}
