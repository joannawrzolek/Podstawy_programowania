using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_wyrazenie
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, v;
            Console.Write("Podaj wartość zmiennej x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wartość zmiennej y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wartość zmiennej z: ");
            z = Convert.ToDouble(Console.ReadLine());

            v = (4 * x - y) / (3 * (z * z + 1));
            Console.WriteLine("Wartość wyrażenia wynosi: ¬{0}.", v, x, y, z);
            Console.ReadKey();


            double r;
            Console.Write("Podaj długość promienia: ");
            r = Convert.ToDouble(Console.ReadLine());

            double pole = Math.PI * r * r;
            double obwod = 2 * Math.PI * r;

            Console.WriteLine("Pole koła o promieniu {0} ¬wynosi: {1:f3}.", r, pole);
            Console.WriteLine("Obwód koła o promieniu {0} ¬wynosi: {1:f3}.", r, obwod);


        }
    }
}
