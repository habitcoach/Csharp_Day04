using System;

public class SimpleGenericClass<T1,T2>
{
   
   

    public SimpleGenericClass()
    {
            
    }

    public SimpleGenericClass(T1 initialValue,T2 initialValue02)
    {
        Value01 = initialValue;
        Value02 = initialValue02;
    }

    public void PrintValue()
    {
        Console.WriteLine("Value of 1: " + Value01);
        Console.WriteLine("Value of 2: " + Value02);
    }

    public T1 Value01 { get; set; }
    public T2 Value02 { get; set; } 


}

class Program
{
    static void Main(string[] args)
    {
        SimpleGenericClass<int,string> intInstance = new SimpleGenericClass<int,string>();
        intInstance.Value01 = 1;
        intInstance.Value02 = "string value";
       
        intInstance.PrintValue();

        SimpleGenericClass<string,string> stringInstance = new SimpleGenericClass<string,string>();
        stringInstance.Value01 = "string value01";
        stringInstance.Value02 = "string value02";
        stringInstance.PrintValue();

        SimpleGenericClass<double,int> doubleInstance = new SimpleGenericClass<double,int>();
        doubleInstance.Value01 = 2.53;
        doubleInstance.Value02 = 2;
        doubleInstance.PrintValue();
    }
}
