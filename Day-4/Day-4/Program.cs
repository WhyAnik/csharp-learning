using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<String> items = new List<String>();
            while (true)
            {
                Console.WriteLine("1.Добавить товар | 2.Показать все товары | 3.Удалить товар | 4.Выход");
                Console.Write("Выберите действие: ");
                int vinput = int.Parse(Console.ReadLine());
                if (vinput == 1)
                {
                    Console.Write("Введите название товара: ");
                    items.Add(Console.ReadLine());
                }
                else if (vinput == 3)
                {
                    Console.Write("Введите название товара: ");
                    string DelItem = Console.ReadLine();

                    if (items.Remove(DelItem))
                    {
                        Console.WriteLine("Товар удалён.");
                    }
                    else
                    {
                        Console.WriteLine("Такого товара нет.");
                    }
                }
                else if (vinput == 2)
                {
                    if (items.Count != 0)
                    {
                        foreach (string item in items)
                        { Console.WriteLine(item); }
                    }
                    else { Console.WriteLine("Список пуст."); }
                }
                else if (vinput == 4)
                { break; }
                else { Console.WriteLine("Неверный пункт."); }

            }
        }
    }
}
