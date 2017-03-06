using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_sortPrzezWstawianie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random r = new Random(); //utworzenie obiektu //generatora liczb pseudolosowych 
            //double n = r.NextDouble(); //losowanie liczby //rzeczywistej z przedziału <0;1>

            double[] tablica = new double[15];

            Random generator = new Random();

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = generator.NextDouble();
            }

            Console.WriteLine("Wylosowano następujące ¬wartości: ");
            foreach (double i in tablica)
            {
                Console.WriteLine("{0:f3}; ", i);
            }

            double x;
            int j;
            for (int i = 1; i < tablica.Length; i++)
            {
                x = tablica[i];
                for (j = i - 1; j >= 0 && x < tablica[j]; j--)
                {
                    tablica[j + 1] = tablica[j];
                }
                tablica[j + 1] = x;
            }

            Console.WriteLine("\n\nElementy tablicy po ¬sortowaniu: ");
            foreach (double i in tablica)
            {
                Console.WriteLine("{0:f3}; ", i);
            }
            Console.ReadKey();
        }
    }
}
