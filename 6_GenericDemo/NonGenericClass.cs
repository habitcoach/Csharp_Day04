using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_GenericDemo
{
    public class NonGenericClass
    {
        private int nonGenericData;

        public NonGenericClass(int data)
        {
            this.nonGenericData = data;
        }

        public void DisplayData()
        {
            Console.WriteLine($"Non-Generic Data: {nonGenericData}");
        }
    }
}
