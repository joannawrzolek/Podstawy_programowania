using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_wartoscWyrazenia
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;

            Console.Write("Podaj wartość zmiennej x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wartość zmiennej y: ");
            y = Convert.ToDouble(Console.ReadLine());

            if (x < 0 && y < 0)
            {
                z = x * y;
            }
            else
            {
                if (x == 0 || y == 0)
                {
                    z = 10;
                }
                else
                {
                    z = x + y;
                }
            }
            Console.Write(" z = {0}", z);
            Console.ReadKey();


        }
    }
}
