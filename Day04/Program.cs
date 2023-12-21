using System;

public class Employee
{
    // Properties
    private string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get;  set; }

    // Constructor
    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    // Method to give a raise to the employee
    public void GiveRaise(double percentage)
    {
        if (percentage < 0)
        {
            throw new ArgumentException("Percentage cannot be negative.");
        }

        double raiseAmount = Salary * (percentage / 100);
        Salary = Salary+ raiseAmount;
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Salary: $" + Salary);
    }
}



public class Program
{
    public static void Main()
    {
        // Creating an employee object and initializing with constructor
        Employee employee1 = new Employee("John Doe", 30, 50000.0);

       // employee1.Name = "some";
        
        // Displaying initial employee details
        employee1.DisplayDetails();

        // Giving a raise of 10% to the employee
        employee1.GiveRaise(10);

        // Displaying updated employee details
        employee1.DisplayDetails();
    }
}




