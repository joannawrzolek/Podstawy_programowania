using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d_promienKola
{
    class Program
    {
        static void Main(string[] args)
        {
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
