using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 2
            var name = "Chad Eddington";
            var location = "Rigby, Idaho";

            // Step 3
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am from {location}");

            // Step 4
            DateTime today = DateTime.Now;
            Console.WriteLine(today.ToString("d"));

            // Step 5
            DateTime christmas = new DateTime(DateTime.Today.Year, 12, 25);
            Console.WriteLine($"There are {(christmas - today).Days} days till Christmas!");

            // Step 6 and 7
            double width, height, woodLength, glassArea; string widthString, heightString;

            Console.Write("Please enter a width (in meters): ");
            widthString = Console.ReadLine(); width = double.Parse(widthString);
            Console.Write("Please enter a length (in meters): ");
            heightString = Console.ReadLine(); height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet"); Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.ReadKey();
        }
    }
}
