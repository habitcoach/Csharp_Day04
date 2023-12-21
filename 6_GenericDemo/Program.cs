// Program.cs
using _6_GenericDemo;
using System;

class Program
{
    static void Main()
    {
        // Using GenericClass with int
        GenericClass<int> genericInt = new GenericClass<int>(42);
        genericInt.DisplayData();

        // Using GenericClass with string
        GenericClass<string> genericString = new GenericClass<string>("Hello, Generics!");
        genericString.DisplayData();

        // Using NonGenericClass with int
        NonGenericClass nonGenericInt = new NonGenericClass(42);
        nonGenericInt.DisplayData();

       
       
    }
}
