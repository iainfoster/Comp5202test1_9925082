using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("-----Question Two-----");
            Console.WriteLine("This program will compute the avarage of 10 numbers");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter a whole number:");
                i += int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a whole number:");
                i += int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a whole number:");
                i += int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a whole number:");
                i += int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a whole number:");
                i += int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a whole number:");
                i += int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a whole number:");
                i += int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a whole number:");
                i += int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a whole number:");
                i += int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a whole number:");
                i += int.Parse(Console.ReadLine());
                Console.WriteLine("the avrage number is:");
                Console.Write(i / 10);
                Console.ReadKey();
            }
        }
    }
}
