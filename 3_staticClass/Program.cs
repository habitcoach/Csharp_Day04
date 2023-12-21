public static class Conversions

{
    

    public static double PoundsToKilos(double pounds)

    {

        // Convert argument from pounds to kilograms

        double kilos = pounds * 0.4536;

        return kilos;

    }

    //Non-static can class can have static and non-static members
    //public  void Test()

    //{

    //    // Convert argument from pounds to kilograms

    //    Console.WriteLine("someting");

    //}

    public static double KilosToPounds(double kilos)

    {

        // Convert argument from kilograms to pounds

        double pounds = kilos * 2.205;

        return pounds;

    }

}

public class Program {

    public static void Main(string[] args) {

        Console.WriteLine("1lb is equivalent to " + Conversions.PoundsToKilos(1.0) + "kg");

        Console.WriteLine("1kg is equivalent to " + Conversions.KilosToPounds(1.0) + "lb");

       
    }
}