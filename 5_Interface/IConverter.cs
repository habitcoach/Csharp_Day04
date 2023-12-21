using System;
namespace _5_Interface
{
    public interface IConverter

    {

        double ImperialToSI(double val);

        double SIToImperial(double val);

        double SIToTest(double val) {

            return 2.0;
        
        }




    }
}

