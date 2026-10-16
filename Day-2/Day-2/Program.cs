using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            Random generation = new Random();
            int rnumber = generation.Next(1, 11);
            Console.Write("Программа загадала число от 1 до 10, попробуйте его угадать: ");
            int input = int.Parse (Console.ReadLine());
            if (input < rnumber)
            {
                Console.Write($"Ваше число ({input}) меньше загаданного ({rnumber})");
            }
            else if (input > rnumber)
            { 
                Console.Write($"Ваше число ({input}) больше загаданного ({rnumber})"); 
            }
            else
            {
                Console.Write($"Поздравляю, вы угадали загаданное число {rnumber}!!!!");
            }
                
            

            

        }
    }
}
