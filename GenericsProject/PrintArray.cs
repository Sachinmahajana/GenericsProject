using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
    internal class PrintArray
    {
        public static void ToPrint(int[] array)
        {
            Console.WriteLine("\nDisplaying integer numbers");
            foreach (int element in array)
            {
                Console.Write(element+" ");
            }
        }
        public static void ToPrint(double[] array)
        {
            Console.WriteLine("\nDisplaying double values");
            foreach (double element in array)
            {
                Console.Write(element + " ");
            }
        }
        public static void ToPrint(char[] sachin)
        {
            Console.WriteLine("\nDisplaying char values");
            foreach (char element in sachin)
            {
                Console.Write(element + " ");
            }
        }
    }
}
