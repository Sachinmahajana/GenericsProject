using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Programs");
            int[] intArray = { 20, 30, 40, };
            double[] doubleArray = { 22.3, 20.4, 30.2 };
            char[] charArray = { 'A', 'B', 'C' };

            Console.WriteLine("PLease Choose a program from below options");
            Console.WriteLine("1.PrintArray\n2.PrintArray by using Generic method\n3.Genericclass Concept");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    PrintArray.ToPrint(intArray);
                    PrintArray.ToPrint(doubleArray);
                    PrintArray.ToPrint(charArray);
                    break;
                case 2:
                    GenericPrintArray.ToPrint<int>(intArray);
                    GenericPrintArray.ToPrint<double>(doubleArray);
                    GenericPrintArray.ToPrint<char>(charArray);
                    break;
                case 3:
                    Genericclass<int> p1 = new Genericclass<int>(intArray);
                    p1.Toprint();
                    Genericclass<double> p2 = new Genericclass<double>(doubleArray);
                    p2.Toprint();
                    Genericclass<char> p3 = new Genericclass<char>(charArray);
                    p3.Toprint();
                    break;
            }
            Console.ReadLine();
        }
    }
}
