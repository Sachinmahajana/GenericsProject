using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
     class Genericclass<T>
    {
        public T[] array;
        public Genericclass(T[] array)
        {
            this.array = array;
        }
        public void Toprint()
        {
            Console.WriteLine("\nDisplaying values");
            foreach(T element in array)
            {
                Console.WriteLine(element + " ");
            }
        }
    }
}
