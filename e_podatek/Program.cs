using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_podatek
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal Vat = 0.22M;
            decimal netto;
            Console.Write("Podaj cenę netto: ");
            netto = Convert.ToDecimal(Console.ReadLine());

            decimal podatek = Vat * netto;
            decimal brutto = netto + podatek;

            Console.WriteLine("Cena wynosi {0:C}, w tym ¬kwota podatku: {1:C}  {0:C}.", brutto, podatek);
            Console.ReadKey();


        }
    }
}
