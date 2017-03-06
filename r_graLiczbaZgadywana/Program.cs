using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r_graLiczbaZgadywana
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 0;
            const int b = 200;

            int n, m;

            Random generator = new Random();
            n = generator.Next(a, b + 1);

            do
            {
                Console.WriteLine("Podaj wartość ¬wylosowanej liczby. Wartość jest z ¬przedziału <{0}, {1}>: ", a, b);
                m = Convert.ToInt32(Console.ReadLine());
                if (m < n) Console.WriteLine("Wartość podana jest ¬za mała");
                if (m > n) Console.WriteLine("Wartość podana jest ¬za duża");
            }
            while (m != n);

            Console.WriteLine("Gratulacje!!! Odgadłeś ¬liczbę.");
            Console.ReadKey();
        }
    }
}
