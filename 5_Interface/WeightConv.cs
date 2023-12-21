using _5_Interface;

public class WeightConverter : IConverter,IUnitNamer

{
    public string NameSI { get { return "kg"; } }

    public string NameImp { get { return "lb"; } }

    public double ImperialToSI(double val)

    {

        return val * 0.4536;

    }

    public double SIToImperial(double val)

    {

        return val * 2.205;

    }

   
}