using System;
using System.Collections.Generic;
namespace IComparerDemo
{
    

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class AgeComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            // Compare persons based on their ages
            int result = x.Age.CompareTo(y.Age);

            // If ages are equal, compare based on names
            if (result == 0)
            {
                result = string.Compare(x.Name, y.Name);
            }

            return result;
        }
    }

}

