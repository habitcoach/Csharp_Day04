class Program {

    public static void Main(string[] args) {

        int value1 = 5;

        printValuePlusOne(value1);

        Console.WriteLine("Value in caller = " + value1);

        void printValuePlusOne(int val)

        {

            val = val + 1;

            Console.WriteLine("Value in function = " + val);

        }

        Console.WriteLine("Value in caller = " + value1);


        IntBox intbox = new IntBox();

        intbox.value = 5;

        printValuePlusOneref(intbox);

        Console.WriteLine("Value in caller = " + intbox.value);

        void printValuePlusOneref(IntBox ib)

        {

            ib.value = ib.value + 1;

            Console.WriteLine("Value in function = " + ib.value);

        }

        Console.WriteLine("Value in caller = " + intbox.value);

    }

}

class IntBox

{

    public int value;

}