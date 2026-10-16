using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your name? ");
            string name = Console.ReadLine();
            Console.Write("Your age? ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your name - {name}, Your age - {age}");

        }
    }
}
