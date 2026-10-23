using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_7
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

            Console.Write("Укажите жанр: ");
            myGame.Genre = Console.ReadLine();

            Console.Write("Укажите дату выхода: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out myGame.Year))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный формат даты. Введите дату числом, пример: 2015");
                }
            }
            games.Add(myGame);
            SaveObjects(games);
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
             if (run ==  false)
            {
                Console.WriteLine("Объекта с таким названием в списке нет");
            }
            else
            {
                Console.WriteLine("Объект успешно удален из списка");
            }
            SaveObjects(games);
        }

        static void ShowList(List<Game>games)
        {
            if (games.Count == 0)
            {
                Console.WriteLine("В списке ничего нет");
            }
            else 
            {
                foreach (Game game in games)
                { Console.WriteLine($"{game.Name} ({game.Genre}, {game.Year})"); }
            }
        }

        static void ShowRandomObject(List<Game>games, Random generation)
        {
            if (games.Count == 0)
            {
                Console.WriteLine("Список пуст");
            }

            else
            {
                int rnumberobject = generation.Next(0, games.Count);
                Game robject = games[rnumberobject];
                Console.WriteLine($"{robject.Name} ({robject.Genre}, {robject.Year})");
            }
        }

        static void LoadObjects(List<Game>games)
        {
            if (File.Exists("games.txt"))
            {
                    string [] lines  = File.ReadAllLines("games.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    Game myGame = new Game();
                    myGame.Name = parts[0]; myGame.Genre = parts[1]; myGame.Year = int.Parse(parts[2]);
                    games.Add(myGame);
                }

            }
         else
            {
                return;
            }
        }

        static void SaveObjects(List<Game>games)
        {
            string[] lines = new string[games.Count];
            for (int i = 0; i < games.Count; i++)
            {
                lines[i] = $"{games[i].Name}|{games[i].Genre}|{games[i].Year}";
            }
            File.WriteAllLines("games.txt", lines);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Game> games = new List<Game>();

            LoadObjects(games);

            Random generation = new Random();

            while(true)
            {
                Console.WriteLine("Выберите действие: |1.Добавить в список|2.Удалить из списка|3.Показать весь список|4.Случайный элемент из списка|5.Выход|");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    if (input == 1)
                    {
                        AddGame(games);
                    }

                    else if (input == 2)
                    {
                        RemoveGame(games);
                    }
                    else if (input == 3)
                    {
                        ShowList(games);
                    }
                    else if (input == 4)
                    {
                        ShowRandomObject(games, generation);
                    }
                    else if (input == 5)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Выбрано неверное действие, повторите попытку.");
                    }
                }

                else
                {
                    Console.Write("Вы ввели не номер действия. Потрите попытку.");
                }
            }
        }
    }
}
