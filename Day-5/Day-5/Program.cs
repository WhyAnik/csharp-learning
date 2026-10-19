using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class Program
    {

        static void AddGame(List<string>games)
        {
            Console.Write("Введите название игры: ");
            games.Add(Console.ReadLine());
        }

        static void ShowGames(List<string>games)
        {
            if (games.Count == 0)
            { 
                Console.Write("Список пуст");
            }
                
            else 
            {
                foreach (string game in games)
                    Console.WriteLine(game);
            }
        }

        static void RemoveGame(List<string>games)
        {
            Console.Write("Введите название игры:");
            string NameGame = Console.ReadLine();
            if (games.Remove(NameGame))
            {
                Console.WriteLine("Игра удалена.");
            }
            else 
            {
                Console.WriteLine("Такой игры в списке нет."); 
            }
        }

        static void ShowRandomGame(List<string>games, Random generation)
        {
            if (games.Count != 0)
            {
                
                int rnumbergame = generation.Next(0, games.Count);
                string rgame = games[rnumbergame];
                Console.WriteLine(rgame);
            }
            else 
            { 
                Console.WriteLine("Список пуст.");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<string> games = new List<string>();
            Random generation = new Random();
            while (true)
            {
                
                Console.Write("Выберите действие: 1.Добавить игру|2.Показать весь список|3.Удалить из списка|4.Случайная игра из списка|5.Выход. ");
                int dinput = int.Parse(Console.ReadLine());
                if (dinput == 1)
                {
                    AddGame(games);
                }
                else if (dinput == 2)
                {
                    ShowGames(games);
                }
                else if (dinput == 3)
                {
                    RemoveGame(games);
                }
                else if (dinput == 4)
                {
                    ShowRandomGame(games, generation);
                }
                else if (dinput == 5)
                {
                    break;

                }
            }

        }
    }
}
