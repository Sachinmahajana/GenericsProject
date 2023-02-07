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
            int[] intArray = { 20, 30, 40, };
            double[] doubleArray = { 22.3, 20.4, 30.2 };
            char[] charArray = { 'A', 'B', 'C' };

            PrintArray.ToPrint(intArray);
            PrintArray.ToPrint(doubleArray);
            PrintArray.ToPrint(charArray);
            Console.ReadLine();
        }
    }
}
