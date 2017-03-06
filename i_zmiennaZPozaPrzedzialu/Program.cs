using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_zmiennaZPozaPrzedzialu
{
    class Program
    {
        static void Main(string[] args)
        {

            int p, q;
            try
            {
            Console.Write("Podaj liczbę p: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbę q: ");
            q = Convert.ToInt32(Console.ReadLine());


            if (p < 0 || p > 2)
               
            throw new ArgumentException("Wartość ¬parametru p musi być z przedziału <0; 1>!");
            //Console.WriteLine(p);
            }
            catch  (ArgumentException ex)
            {
                Console.WriteLine("Wartośc z poza przedziału", ex.Message);
            }

            Console.ReadKey();

        }
    }
}
