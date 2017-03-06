using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t_szescLiczbZPrzedzialu
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] numery = new byte[6];

            Random generator = new Random();
            int index = 0;
            //ile wylosowano liczb 
            int i;
            bool flaga;
            do
            {
                numery[index] = (byte)generator.Next(1,50);
                flaga = true;
                for (i=0; i<index; i++)
                {
                    if (numery[index] == numery[i])
                    {
                        flaga = false;
                        break;
                    }
                }
                if (flaga)
                {
                    index++;
                }
            } while(index<6);

            Console.WriteLine("Wylosowane liczby to:");
            foreach (int numer in numery)
            {
                Console.Write("{0}, ", numer);
            }
            Console.ReadKey();
        }
    }
}
