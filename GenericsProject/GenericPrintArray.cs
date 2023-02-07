using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
    internal class GenericPrintArray
    {
        public static void ToPrint<T>(T[] array)
        {
            Console.WriteLine("\nDisplaying values");
            foreach(T element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}