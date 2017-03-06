using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_ClearArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Array.Clear(tab, 2, 4);

            //foreach (int i in tab)
            //{
            //    Console.Write("{0}, ", i);
            //}

            //-----------------------------------------------------------------------------------------

            //int[] tab1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] tab2 = { 11, 12, 13, 14, 15, 16, 17, 18, 19 };

            //Array.Copy(tab1, 1, tab2, 4, 3);

            //foreach (int i in tab2)
            //{
            //    Console.WriteLine("{0}, ", i);
            //}


            //-----------------------------------------------------------------------------------------


            ////odwracanie tablic
            //int[] tab1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Array.Reverse(tab1);
            //foreach (int i in tab1)
            //{
            //   Console.WriteLine("{0}, ", i);
            //}

            ////sortowanie tablic
            //int[] tab1 = { 4, 1, 83, 41, 53, 36, 47, 18, 29 };
            //Array.Sort(tab1);
            //foreach (int i in tab1)
            //{
            //    Console.WriteLine("{0}, ", i);
            //}

            // wyszukiwanie elementu w tablicy
            // najmniejszy index minus 1 = -1
            //W przypadku, gdy podany jest trzeci argument, metoda IndexOf rozpocznie przeszukiwanie tablicy od elementu o indeksie równym wartości trzeciego argumentu. Oczywiście przy braku trzeciego argumentu, metoda IndexOf rozpocznie przeszukiwanie tablicy od pierwszego elementu, a LastIndexOf od ostatniego.

            int[] tab1 = { 2, 5, 7, 5, 12, 6, 5 };
            int i = Array.IndexOf(tab1, 5, 3);
            while (i != -1)
            {
                Console.WriteLine("{0}, ", i);
                i = Array.IndexOf(tab1, 5, i + 1);
            }


            //W celu porównania elementu z podaną wartością używa się metody Object.Equals.
            //metody Exists, FindLast, FindAll, FindIndex, FindLastIndex,
            //Sortowaniem w miejscu nazywamy metodę, która nie potrzebuje tworzenia dodatkowej tablicy, do której przenosimy elementy.

        }
    }
}
