using System;
namespace _5_Interface
{
	public class Program
	{
		public static void Main(string[] args) {

            void OutputToSI(IConverter conv, double value, string imp, string si)

            {
                
                Console.WriteLine(value + imp + " is equivalent to " + conv.ImperialToSI(1.0) + si + " in SI units");

            }

            IConverter convWeight = new WeightConverter();

            

            IConverter convLength = new LengthConverter();

         
             

            OutputToSI(convWeight, 1.0, "lb", "kg");

            OutputToSI(convLength, 1.0, "ft", "m");


            //multiple interface
            var weight = new WeightConverter();

            OutputToSI(weight, 1.0, weight.NameImp, weight.NameSI);


        }	
	}
}

