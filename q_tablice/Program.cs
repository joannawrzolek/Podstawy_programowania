using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q_tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] t = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //foreach(int element in t)
            //{
            //    Console.WriteLine("{0}", element);
            //}


            int[] tablica = new int[15];
            Random generator = new Random();
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = generator.Next(0, 101);
            }

            Console.WriteLine("Wylosowano następujące ¬wartości");
            foreach (int i in tablica)
            {
                Console.WriteLine("{0}, ", i);
                Console.WriteLine("==============================================================================");
            }

            int indexMax = 0;
            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[indexMax] < tablica[i])
                {
                    indexMax = i;
                }
                
            }

            int indexMin = 0;
            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[indexMin] > tablica[i])
                {
                    indexMin = i;
                }
            }

            Console.WriteLine("Elemnt największy o indeksie ¬{0} posiada wartość {1}.", indexMax, tablica[indexMax]);

            Console.WriteLine("Elemnt największy o indeksie ¬{0} posiada wartość {1}.", indexMin, tablica[indexMin]);

            Console.ReadKey();
        }
    }
}
