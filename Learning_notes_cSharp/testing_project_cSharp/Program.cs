using System;
using System.Xml;

namespace testing_project_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\television\sony\bravia.txt";
            //we write the @ for the string not to use the verbatim string

            int decimlaNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;
            //the above values are the same

            //Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}");
            //Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}");
            //Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");
            //the size of each type of variable

            decimal DecimalNumber = 12.75M;
            //M suffix means a decimal literal value
            //when declaring a double the values are stored by the IEEE format
            //but when declaring decimal for example 12.75 it stores it like 1275 with
            //a note to shift the decimla point two places to the left


            dynamic something = "ahmad";
            something = 12;
            something = new[] { 8, 2, 5 };
            //the value stored in the variable can have its memebers invoked without an explicit cast

            var somethingElse = 5;
            //you can use the var keyword to declare local variables the compiler will infer the type from the value that you assign

            /*
            a literal number without a decimal point is inferred as an int variable ,that is, unless you add a suffix, as in the list below:
            L : long 
            UL: ulong
            M : decimal
            D : double
            F : float

            a literal number with a decimal point is inferred as a double unlesss you add the M suffix or F suffix.
            */

            XmlDocument xml = new XmlDocument();
            XmlDocument xml1 = new(); //target-typed new in c# 9 or later && we use this instead of the above one

            string[] names5 = new[] { "ali", "ahmad" };
            //when using the new[] syntax to allocate memory for the array, you must have at least
            //one item in the durly braces so that the compiller can infer the dat type

            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;
            string formatted = string.Format(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples);
            Console.WriteLine(formatted);
        }
    }
}
