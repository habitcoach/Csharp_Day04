using System;
using System.Collections;
using System.Collections.Generic;

public class MyCollection<T> : IEnumerable<T>
{
    private List<T> items = new List<T>();

    //Add value to the interanl list.  It is calle when you add new elemen to the orginal list
    public void Add(T item)
    {
        items.Add(item);
    }

    // Implementing the IEnumerable<T> interface
    //The GetEnumerator had moveNext method which will help us to move to the next object
    public IEnumerator<T> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    // Implementing the non-generic IEnumerable interface
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyCollection<int> numbers = new MyCollection<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        int[] numbers02 = new int[] { 1, 2, 3 ,4};

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        #region Notes
        /*
         The reason this works is because arrays implicitly support iteration through the foreach loop. 
        The compiler knows how to iterate over array elements without requiring the array to explicitly 
        implement IEnumerable or IEnumerable<T>.
         */
        #endregion
        foreach (int number in numbers02)
        {
            Console.WriteLine(number);
        }
    }
}
