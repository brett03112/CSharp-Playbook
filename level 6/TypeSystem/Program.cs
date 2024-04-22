/*
 * This program identifies all 16 types that are
 * used in the C# type system.
 */

namespace TypeSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 23; // -2,147,483,648 to 2,147,483,647
            Console.WriteLine(num + " is an integer.");
            byte aSmallByte = 34;// 0 to 255
            Console.WriteLine(aSmallByte + " is a byte.");
            short number = 5039; //-32768 to 32767
            Console.WriteLine(number + " is a short.");
            long bigNum = 395662587;// big int
            Console.WriteLine(bigNum + " is a long.");
            sbyte little = 120; //-128 to 127
            Console.WriteLine(little + " is an sbyte.");
            ushort small = 12; // 0 to 65535
            Console.WriteLine(small + " is a ushort.");
            uint tiny = 32556; // 0 to 4,294,967,295
            Console.WriteLine(tiny + " is a uint.");
            ulong sortOfBig = 399856985; // 0 - 18,446,744,073,709,551,615
            Console.WriteLine(sortOfBig + " is a ulong.");

            int thirteen = 0b00001101; // binary
            Console.WriteLine(thirteen + " is an integer binary.");
            int theColorMagenta = 0xFF00FF; // hexadecimal 
            Console.WriteLine(theColorMagenta + " is an integer hexadecimal.");

            char letterA = 'a'; // character a
            Console.WriteLine(letterA + " is a character.");
            string message = "Hello World";
            Console.WriteLine(message + " is a string.");

            double num1 = 3.14159;
            Console.WriteLine(num1 + " is a double value.");
            float num2 = 3.14159f;
            Console.WriteLine(num2 + " is a float value.");
            decimal num3 = 3.14159m;
            Console.WriteLine(num3 + " is a decimal value.");

            bool itWorked = true;
            bool notWork = false;
            Console.WriteLine(itWorked + " and " + notWork + " is a boolean value.");

        }
    }
}