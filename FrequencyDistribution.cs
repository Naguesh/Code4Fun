using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace FrequencyDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbersWithSpaces = System.IO.File.ReadAllText(@""+args[0]+"");
            string numbersWithASpace = Regex.Replace(numbersWithSpaces, @"\s+", " ");
            string[] numbers = numbersWithASpace.Split(' ');

            var frequencyDistribution = from row in numbers
                         orderby row
                         group row by row into g
                         select new
                         {
                             number = g.Key,
                             frequency = g.Count()
                         };
            Console.WriteLine("Numbers\t\tFrequency\n");

            foreach (var f in frequencyDistribution)
            {
                Console.WriteLine("{0}\t\t{1}", f.number.ToString(), f.frequency.ToString());
            }

            Console.ReadKey();
        }
    }
}
