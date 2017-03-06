using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zamiana
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, tmp;

            Console.Write("Podaj wartość zmiennej a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wartość zmiennej b: ");
            b = Convert.ToDouble(Console.ReadLine());

            tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.ReadKey();


        }
    }
}
