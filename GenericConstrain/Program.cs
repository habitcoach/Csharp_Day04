using System;

public class SimpleGenericClass<T> where T:new()
{
   


    public SimpleGenericClass()
    {

    }

    public SimpleGenericClass(T initialValue)
    {
        Value = initialValue;
    }

    public void PrintValue()
    {
        Console.WriteLine("Value: " + Value);
    }

    public T Value { get; set; }


}

class Program
{
    static void Main(string[] args)
    {
        SimpleGenericClass<int> intInstance = new SimpleGenericClass<int>();
        intInstance.Value = 1;

        intInstance.PrintValue();

        ////This will throw an error because it has string that does'nt have public parameterless constructor
        //SimpleGenericClass<string> stringInstance = new SimpleGenericClass<string>();
        //stringInstance.Value = "string value";
        //stringInstance.PrintValue();

        SimpleGenericClass<People> peopleInstance = new SimpleGenericClass<People>();
        peopleInstance.Value = new People();
        peopleInstance.PrintValue();

        SimpleGenericClass<double> doubleInstance = new SimpleGenericClass<double>();
        doubleInstance.Value = 2.53;
        doubleInstance.PrintValue();
    }
}

public class People {

    public People()
    {
            
    }



    //This one will throw an error
    //public People(int i)
    //{


    //}

}


#region Interface constraint 


/*
public class SimpleGenericClass<T> where T : ITest
{



    public SimpleGenericClass()
    {

    }

    public SimpleGenericClass(T initialValue)
    {
        Value = initialValue;
    }

    public void PrintValue()
    {
        Console.WriteLine("Value: " + Value);
    }

    public T Value { get; set; }


}

class Program
{
    static void Main(string[] args)
    {
      

     

        SimpleGenericClass<People> peopleInstance = new SimpleGenericClass<People>();
        peopleInstance.Value = new People();
        peopleInstance.PrintValue();

        
    }
}

public class People: ITest
{

   

    public void MyMethod()
    {
        throw new NotImplementedException();
    }



    //This one will throw an error
    //public People(int i)
    //{


    //}

}

public interface ITest {

    public void MyMethod();
}
 

 */

#endregion