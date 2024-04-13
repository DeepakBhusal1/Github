using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// This program calculates the area of a triangle based on user input for base length and height.

namespace Deepak1
{
    class Program
    {
        static void Main()
        {
            double baseLength, height;

            // Input base length of the triangle
           Console.Write("Enter the base length (in meters) of the triangle: ");
            baseLength = Convert.ToDouble(Console.ReadLine());

            // Input height of the triangle
            Console.Write("Enter the height of the triangle: ");
            height = Convert.ToDouble(Console.ReadLine());

            // Calculate area
            double area = 0.5 * baseLength * height;

            // Display the calculated area
            Console.WriteLine($"The area of the triangle is: {area}");
        }
    }
}