using System;
using System.Collections.Generic;

using IComparerDemo;
public class Program
{
    public static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person("Alice", 25),
            new Person("Bob", 30),
            new Person("Charlie", 20),
            new Person("David", 22),
            new Person("Charlie", 18),
            new Person("Alice", 22)
        };

        // Sorting the list based on age using AgeComparer
        people.Sort(new AgeComparer());

        // Display the sorted list
        foreach (Person person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
