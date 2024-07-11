using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int area = length * width;
            int perim = (2 * width) + (2 * length);
            
            Console.WriteLine("The area is: " + area);
            Console.WriteLine("The perimeter is: " + perim);
        }
    }
}