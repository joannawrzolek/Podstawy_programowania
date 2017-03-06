using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o_sumaIIlocznynLPierwszych
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong iloczyn = 1, suma = 0;
            ushort a, k, n;

            Console.Write("Podaj wartość zmiennej n: ");
            n = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Podaj wartość zmiennej k: ");
            k = Convert.ToUInt16(Console.ReadLine());

            a = k;

            for (int i = 0; i < n; i++)
            {
                suma += a;
                checked
                {
                    iloczyn *= a;
                }
                a += k;
            }
            Console.Write(" suma = {0}", suma);
            Console.Write(" iloczyn = {0}", iloczyn);
            Console.ReadKey();
        }
    }
}
