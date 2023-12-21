using System;
namespace IComparableDemo
{
    using System;

    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person otherPerson)
        {
            #region Notes

            /*
             When sorting an array or a list of Person objects, the sorting algorithm uses the return value(+,0 or -) 
            of CompareTo to determine the order of elements.
             */

            #endregion
            // Compare persons based on their ages
            return this.Age.CompareTo(otherPerson.Age);

            // Compare persons based on their Name
            // return this.Name.CompareTo(otherPerson.Name);
        }
    }

}

