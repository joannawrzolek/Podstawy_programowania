using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h_liczbaParzysta
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Podaj liczbę: ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("x jest liczbą parzystą");
            }
            else
            {
                Console.WriteLine("x jest liczbą nie parzystą");
            }

        }
    }
}
