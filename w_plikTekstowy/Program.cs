using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace w_plikTekstowy
{
     class Plik_tekstowy
    {
        string dane, dane1;
        FileStream fout, fin;

        public void czytaj_dane()
        {
            Console.WriteLine("Wpisujemy dane do pliku tekstowego: ");
            Console.WriteLine("Podaj imie i nazwisko");
            dane = Console.ReadLine();
        }

        public void zapisz_dane_do_pliku()
        {
            string path = @"E:\dane.txt";
            fout = new FileStream(path, FileMode.Create);
            StreamWriter fstr_out = new StreamWriter(fout);

            fstr_out.Write(dane);
            fstr_out.Close();
            fout.Close();
        }

        public void czytaj_dane_z_pliku()
        {
            Console.WriteLine();
            Console.WriteLine("Odczytujemy dane z pliku txt.");

            string path = @"E:\dane.txt";
            fin = new FileStream(path, FileMode.Open);
            StreamReader fstr_in = new StreamReader(fin);

            while ((dane1 = fstr_in.ReadLine()) != null)
            {
                Console.WriteLine(dane1);
            }
            fstr_in.Close();
            fin.Close();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Plik_tekstowy plik = new Plik_tekstowy();

            plik.czytaj_dane();
            plik.zapisz_dane_do_pliku();
            plik.czytaj_dane_z_pliku();

            Console.Read();

        }
    }
}
