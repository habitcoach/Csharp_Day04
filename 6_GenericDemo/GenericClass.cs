using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_GenericDemo
{
   
    public class GenericClass<T>
    {
        private T genericData;

        public GenericClass(T data)
        {
            this.genericData = data;
        }

        public void DisplayData()
        {
            Console.WriteLine($"Generic Data: {genericData}");
        }
    }

    // NonGenericClass.cs
   

}
