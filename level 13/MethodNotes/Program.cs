namespace MethodNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            /*
            Format Character Description Default Format (if no precision is given)
            C or c Currency $XX,XXX.XX
            ($XX,XXX.XX)
            D or d Decimal [2]XXXXXXX
            E or e Scientific
            (exponential)
            [2]X.XXXXXXE1xxx
            [2]X.XXXXXXe1xxx
            [2]X.XXXXXXE-xxx
            [2]X.XXXXXXe-xxx
            F or f Fixed point [2]XXXXXXX.XX
            G or g General Variable; either with decimal places or scientific
            N or n Number [2]XX,XXX.XX
            P or p Percent Represents a numeric value as a percentage
            R or r Round trip Ensure that numbers converted to strings will have
            the same values when they are converted back into
            numbers
            X or x Hexadecimal Minimum hexadecimal (base 16) representation

                    double someMoney = 123;
                    string moneyString;
                    moneyString = someMoney.ToString("F");
                    WriteLine(moneyString);
                    moneyString = someMoney.ToString("F3");
                    WriteLine(moneyString);

                    double moneyValue = 456789;
                    string conversion;
                    conversion = moneyValue.ToString("C");
                    WriteLine(conversion);
            */
            void CountToTen()
            {
                for (int current = 1; current <= 10; current++)
                    Console.WriteLine(current);
            }

            CountToTen();
            Console.WriteLine();
            CountToTwenty();

            void CountToTwenty()
            {
                for (int current = 1; current <= 20; current++)
                    Console.WriteLine(current);
            }

            Console.WriteLine();
            /// <summary>
            /// Counts to the given number, starting at 1 and including the number provided.
            /// </summary>
            static void Count(int numberToCountTo)
            {
                for (int current = 1; current <= numberToCountTo; current++)
                    Console.WriteLine(current);
            }
            Count(35);

            Console.WriteLine();

            static void CountBetween(int start, int end)
            {
                for (int current = start; current <= end; current++)
                    Console.WriteLine(current);
            }
            CountBetween(35, 40);

            Console.WriteLine();

            

            int ReadNumber()
            {
                int num = int.Parse(Console.ReadLine());
                
                return num;
            }
            ReadNumber();

            Console.WriteLine();
            Console.Write("How high should I count?");
            int chosenNumber = ReadNumber();
            Count(chosenNumber);
            Console.WriteLine();
            
            string GetUserName()
            {
                while (true)
                {
                    Console.Write("What is your name? ");
                    string name = Console.ReadLine();
                    if (name != "") // Empty string
                        return name;
                    Console.WriteLine("Let's try that again.");
                }
            }
            string name = GetUserName();
            Console.WriteLine(name);
            Console.WriteLine();
            //allows the method to return nothing if there is a wrong parameter
            static void Count2(int numberToCountTo)
            {
                if (numberToCountTo < 1)
                    Console.WriteLine("It needs to be positive and an integer!!");
                    return;
                for (int index = 1; index <= numberToCountTo; index++)
                    Console.WriteLine(index);
            }
            Count2(-3);

            Console.WriteLine();
            //recursion
            int Factorial(int number)
            {
                if (number == 1) return 1;
                return number * Factorial(number - 1);
            }
            Console.WriteLine(Factorial(10));

            //Countdown using recursion

            int CountDown(int num)
            {
                Console.WriteLine(num);
                if (num == 1) return 1;
                return CountDown(num - 1);
                
            }
            CountDown(10);


        }
    }
}