using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace y_wyszukiwanieBinarne
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] miasta = { "Poznań", "Warszawa", "Częstochowa", "Gdańsk", "Łódź", "Kraków", "Wrocław", "Białystok", "Szczecin" };
            Array.Sort(miasta);
            Console.WriteLine("Elementy tablicy po ¬sortowaniu: ");

            foreach (string miasto in miasta)
            {
                Console.WriteLine("{0}, ", miasto);
            }

            Console.Write("\n\nPodaj nazwę miasta: ");
            string s = Console.ReadLine();

            int lewy = 0, prawy = miasta.Length - 1;
            int srodek = (lewy + prawy) / 2;

            int flaga;
            while (lewy <= prawy)
            {
                flaga = String.Compare(s, miasta[srodek]);
                if (flaga == 0)
                {
                    break;
                }
                else
                {
                    if (flaga < 0)
                    {
                        prawy = srodek - 1;
                    }
                    else
                    {
                        lewy = srodek + 1;
                    }
                }
                srodek = (lewy + prawy) / 2;
            }

            if (lewy <= prawy)
            {
                Console.WriteLine("Podane miasto ma w tablicy ¬indeks {0}.", srodek);
            }
            else
            {
                Console.WriteLine("Tablica nie zawiera podanego ¬miasta.");
            }
            Console.ReadKey();

        }
    }
}
