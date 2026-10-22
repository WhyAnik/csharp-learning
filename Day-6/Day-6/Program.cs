using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Game
    {
        public string Name;
        public string Genre;
        public int Year;
    }

    internal class Program
    {
        static void AddGame(List<Game>games)
        {
            Game myGame = new Game();
            Console.Write("Введите название: ");
            myGame.Name = Console.ReadLine();

            Console.Write("Введите жанр игры: ");
            myGame.Genre = Console.ReadLine();

            Console.Write("Введите год выхода игры: ");
            myGame.Year = int.Parse(Console.ReadLine());
            games.Add(myGame);
        }

        static void ShowGame(List<Game>games)
        {
            
            if (games.Count == 0)
            {
                Console.Write("Список пуст");
                return;
            }

            else
            {
                foreach (Game game in games)
                    Console.WriteLine($"{game.Name} ({game.Genre}, {game.Year}) ");
            }
        }

        static void RemoveGame(List<Game>games)
        {
            Console.Write("Введите название: ");
            string ngame = Console.ReadLine();
            bool run = false; 

                for (int i = 0; i < games.Count; i ++)
                {
                    if (games[i].Name == ngame)
                    {
                        games.RemoveAt(i);
                        run = true;
                        break;
                    }
            }

            if (run == false)
                {
                    Console.WriteLine("Такой игры в списке нет.");
                }
                else
                {
                    Console.WriteLine("Игра удалена.");
                }

        }

        static void ShowRandomGame(List<Game>games, Random generation)
        {
            if (games.Count != 0)
            {
                int rnumbergame = generation.Next(0, games.Count);
                Game rgame = games[rnumbergame];
                Console.WriteLine($"{rgame.Name} ({rgame.Genre}, {rgame.Year})");
            }
            else
            {
                Console.Write("Список пуст");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Game> games = new List<Game>();

            Random generation = new Random();
            while(true)
            {
                Console.Write("Выберите действие |1.Добавить в список|2.Показать весь список|3.Удалить из списка|4.Случайная игра из списка|5.Выход|");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    AddGame(games);
                }

                else if (input == 2)
                {
                    ShowGame(games);
                }

                else if (input == 3)
                {
                    RemoveGame(games);
                }

                else if (input == 4)
                {
                    ShowRandomGame(games, generation);
                }
                else if (input == 5)
                {
                    break;
                }
            }

        }
    }
}
