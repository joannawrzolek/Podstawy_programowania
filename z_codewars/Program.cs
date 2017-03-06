using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace z_codewars
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Calculate Meal Total
            //double subtotal = 208;
            //int tax = 23;
            //int tip = 10;
            //Console.WriteLine(Math.Round(((subtotal + subtotal * tax / 100) + subtotal * tip / 100), 2));




            ////silnia factorial
            //int n = 4;
            //var result = 1;
            //for (int i = 2; i <= n; ++i)
            //{
            //    result *= i;
            //}
            //Console.WriteLine(result);





            //silnia
            //uint n;
            //Console.Write("Podaj n: ");
            //n = Convert.ToUInt32(Console.ReadLine());
            //if (n < 2)
            //    Console.WriteLine("Silnia dla liczby n = 1 wynosi 1");
            //long iloczyn = 1;
            //for (uint i = 2; i <= n; i++)
            //{
            //    iloczyn *= i;
            //}
            //Console.WriteLine(iloczyn);




            ////Sum of all the multiples of 3 or 5
            ////wielokrotnosci 3 i 5 
            //int Sum = 0;
            //int n = 10;
            //for (int i = 0; i <= n; i++)
            //{
            //    if ((i % 3 == 0) || (i % 5 == 0))
            //        Sum += i;
            //}
            //Console.WriteLine(Sum);





            //Even or Odd
            //liczby parzyste i nie parzyste
            //int x;
            //Console.Write("Podaj liczbę: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}





            ////Biorąc pod tablicę jeden i Zero przekonwertować równoważną wartość binarną do liczby całkowitej.
            ////Ones and Zeros
            //int[] BinaryArray = { 0, 0, 1, 1 };
            //int suma = 0;
            //int zmienna = 1;
            //for (int i = BinaryArray.Length - 1; i >= 0; i--)
            //{
            //    suma += BinaryArray[i] * zmienna;
            //    zmienna = zmienna * 2;
            //}
            //Console.WriteLine(suma);




            ////Is this a triangle?
            //int a = 5;
            //int b = 7;
            //int c = 10;
            //Console.WriteLine(a + b > c && b + c > a && a + c > b);




            ////Exclusive "or"(xor) Logical Operator
            //bool a = true;
            //bool b = false;
            //Console.WriteLine(a ^ b);





            ////7-segment converter
            //int number = 2;
            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine(0x50);
            //        break;
            //    case 2:
            //        Console.WriteLine(0x37);
            //        break;
            //    case 3:
            //        Console.WriteLine(0x57);
            //        break;
            //    case 4:
            //        Console.WriteLine(0x5A);
            //        break;
            //    case 5:
            //        Console.WriteLine(0x4F);
            //        break;
            //    case 6:
            //        Console.WriteLine(0x6F);
            //        break;
            //    case 7:
            //        Console.WriteLine(0x51);
            //        break;
            //    case 8:
            //        Console.WriteLine(0x7F0);
            //        break;
            //    case 9:
            //        Console.WriteLine(0x5F);
            //        break;
            //    case 0:
            //        Console.WriteLine(0x7D);
            //        break;
            //    default:
            //        throw new System.Exception();
            //}






            ////Don't give me five!
            ////pojawi się numer startowy i końcowy numer regionu i powinna zwracać liczbę wszystkich liczb wyjątkiem numerów z 5 w nim. Początek i koniec są liczba włącznie!
            //int start = 1;
            //int end  = 12;
            //int count = end - start + 1;
            //for (int i = start; i <= end; i++)
            //{
            //  if (i.ToString().Contains("5")) count--;
            //}
            //Console.WriteLine(count);






            ////Calculate average 
            ////Write function avg which calaculates average of numbers in given list.
            //double[] array = new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 13 };
            //if (array == null || array.Count() == 0)
            //    Console.WriteLine(0);
            //Console.WriteLine(array.Average());
            ////double sr = array.Average();
            //Console.WriteLine(Math.Round(array.Average(), 2));



            ////Hex to Decimal
            ////function hexToDec which converts hex number (given as a string) to decimal number 16->int
            //string hexString = "-12";
            //var n = Convert.ToInt32(hexString.Replace("-", ""), 16);
            //Console.WriteLine(n);



            ////Find the position!
            ////When provided with a letter, return its position in the alphabet.
            //char alphabet = ('b');
            ////Console.WriteLine("Position of alphabet: " + (alphabet - 'b' + 2));
            //Console.WriteLine($"Position of alphabet: {(1 + alphabet - 'a')}");
            ////Console.WriteLine(alphabet);
            ////Console.WriteLine(1 + alphabet - 'a');




            ////Sum of a sequence
            //// task is to make function, which returns the sum of a sequence of integers.The sequence is defined by 3 non - negative values: begin, end, step.
            //// If begin value is greater than the end, function should returns 0
            //var sum = 0;
            //int begin = 6;
            //int end = 8;
            //int step = 1;
            //for (var i = begin; i <= end; i += step)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);




            ////policzyć ilosc ! i ?
            ////Exclamation marks series #13: Count the number of exclamation marks and question marks, return the 
            //string str = "!!!!!?????kksd!sfjk";
            //int exclamationMark = 0;
            //int questionMark = 0;
            //foreach (var mark in str)
            //{
            //    if (mark == '!')
            //    {
            //        exclamationMark++;
            //    }
            //    else if (mark == '?')
            //    {
            //        questionMark++;
            //    }
            //}
            //Console.WriteLine(exclamationMark * questionMark);





            //======================================================================================
            //  Build a pile of Cubes
            ////function findNb(m) {
            ////    var k = Math.floor(Math.sqrt(Math.sqrt(m) * 2));
            ////    if (k * k * (k + 1) * (k + 1) / 4 == m)
            ////        return k;
            ////    return -1;
            ////}
            //===========================================================================================

            ////Count the Ones
            //function hammingWeight(x){
            //    let i = 1;
            //    while (i < x) { i *= 2; }
            //    let weight = 0;
            //    while (i >= 1)
            //    {
            //        if (x >= i)
            //        {
            //            weight++;
            //            x -= i;
            //        }
            //        i /= 2;
            //    }
            //    return weight;
            //}







        }
    }  
}
