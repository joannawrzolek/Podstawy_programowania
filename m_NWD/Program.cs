using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_NWD
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong m, n, roznica;
            Console.Write("Podaj wartość m: ");
            m = Convert.ToUInt64(Console.ReadLine());
            Console.Write("Podaj wartość n: ");
            n = Convert.ToUInt64(Console.ReadLine());

            do
            {
                roznica = m > n ? m - n : n - m;
                if (n > m)
                    n = roznica;
                else
                    m = roznica;
            }
            while (roznica != 0);

            Console.WriteLine("Największy wspólny dzielnik ¬podanych liczb to {0}.", n);
            Console.ReadKey();
        }
    }
}
