using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_pierwiastekkwadratowy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zdefiniuj maksymalny dopuszczalny błąd:
            const double epsilon = 0.00001;
            double a;
            double x = 1;
            Console.Write("Podaj wartość zmiennej a: ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a < 0)
                throw new Exception("a nie może być ujemne");

            while (Math.Abs(x * x - a) > epsilon)
            {
                x = (x + a / x) / 2;
            }

            Console.WriteLine(a);
            Console.WriteLine(x);
            //Console.WriteLine("Wartością (przybliżoną) ¬pierwiastka kwadratowego liczby { 0} jest{ 1}.", a);
            Console.ReadKey();
        }
    }
}
