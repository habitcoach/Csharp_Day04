using _5_Interface;

public class LengthConverter : IConverter,IUnitNamer

{
    public string NameSI { get { return "m"; } }

    public string NameImp { get { return "ft"; } }

    public double ImperialToSI(double val)

    {

        // Convert argument from feet to metres

        return val * 0.3048;

    }

    public double SIToImperial(double val)

    {

        return val * 3.28084;

    }

   
}