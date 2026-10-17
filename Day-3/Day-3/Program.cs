using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random generation = new Random();
            int rnumber = generation.Next(1, 101);
            Console.WriteLine("Программа загадала число от 1 до 100, попробуйте его угадать. У вас есть 5 попыток.");
            bool iswin = false;
            for (int score = 0; score < 5; score ++)
            {
                Console.Write("Ввод: ");
                int input = int.Parse(Console.ReadLine());
                if (input > rnumber)
                {
                    Console.WriteLine($"Ваше число: {input} больше загаданного");
                }
                else if (input < rnumber)
                {
                    Console.WriteLine($"Ваше число: {input} меньше загаданного");
                }
                else
                {
                    iswin = true;
                    break;
                }
            }
            if (iswin == true)
            { Console.Write($"ПОБЕДА! Загаданное число: {rnumber}");}
            else
            { Console.WriteLine($"Попытки закончились. Загаданное число: {rnumber}"); }

        }
    }
}
