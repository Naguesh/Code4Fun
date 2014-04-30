using System;

namespace HipHopWazaa
{
    class Program
    {
        /*
         * 
         * (#1) Write a function (in any language) which takes 'n' as an argument and prints all 
         * the numbers from 1 to 'n', except that: 
         * (a) if a number is divisible by 3, it should print 'Hip'instead of the number, 
         * (b) if divisible by 5 it should print 'Hop', and 
         * (c) if divisible by 3 & 5, it should print 'Whazaa' instead of the number.
         * 
         */

        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            string stringValue = Console.ReadLine();

            int intValue = 0;
            if (int.TryParse(stringValue, out intValue)) // Try to parse the string as an integer
            {
                if (intValue > 0)
                    PrintNumbers(intValue);
                else
                    Console.WriteLine("Number should be greater than Zero!");
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }
            Console.WriteLine("Print complete!");
            Console.ReadKey();
        }

        /// <summary>
        /// Print numbers or message based on the input value.
        /// Assumption made that any one of the message "Hip" , "Hop" or "Whazaa" 
        /// instead of nubers if the condtions is satisfied
        /// </summary>
        /// <param name="value"></param>
        static void PrintNumbers(int value)
        {
            Console.WriteLine("Who is Hip Hop Wazaa!");
            for (int i = 1; i <= value; i++)
            {
                bool isDivisibleByThree = (i % 3 == 0);
                bool isDivisibleByFive = (i % 5 == 0);

                if (!isDivisibleByThree && !isDivisibleByFive)
                    Console.WriteLine("{0}", i.ToString());
                else
                {
                    if (isDivisibleByThree && isDivisibleByFive)
                    {
                        Console.WriteLine("Whazaa");
                        continue;
                    }

                    if (isDivisibleByThree)
                    {
                        Console.WriteLine("Hip");
                        continue;
                    }

                    if (isDivisibleByFive)
                    {
                        Console.WriteLine("Hop");
                        continue;
                    }
                }
            }            
        }
    }
}
