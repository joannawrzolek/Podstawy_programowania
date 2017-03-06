using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g_czyWKole_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            const double SrodekX = 0;
            const double SrodekY = 0;
            const double Promien = 4;
            Console.Write("Program sprawdza, czy punkt o współrzednych podanych przez użytkownika, należy do koła ");
            Console.WriteLine(" o środku w punkcie ({0}, {1}) i promieniu {2}.\n", SrodekX, SrodekY, Promien);
            double x, y;    //Współrzędne punktu
            Console.Write("Podaj współrzędną x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj współrzędną y: ");
            y = Convert.ToDouble(Console.ReadLine());
            //Metoda Sqrt oblicza pierwiastek kwadratowy
            double odleglosc = Math.Sqrt((x - SrodekX) * (x - SrodekX) + (y - SrodekY) * (y - SrodekY));

            if (odleglosc <= Promien)
            {
                Console.WriteLine("Punkt należy do koła");
            }
            else
            {
                Console.WriteLine("Punkt nie należy do koła");
            }

            Console.ReadKey();
        }
    }
}
