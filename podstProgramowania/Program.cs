using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_podstProgramowania
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cześc :)");
            Console.ReadKey(true);
            Console.WriteLine("Koniec");
            Console.ReadLine();


            double x, y, suma;
            Console.Write("Podaj x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj y: ");
            y = Convert.ToDouble(Console.ReadLine());
            suma = x + y;
            Console.WriteLine("{0}+{1}={2}", x, y, suma);
            Console.ReadKey();
        }    
    }
}
