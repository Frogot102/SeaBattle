using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Морской бой против компьютера");
            string vibor;
            do
            {
                Console.WriteLine("Введите число чтобы \n (1) - Узнать правила игры \n (2) - Узнать обозначения на игровом поле \n (3) - Включить режим разработчика \n (4) - Выбрать сложность \n (5) - Завершить игру");
                vibor = Console.ReadLine();

                switch (vibor)
                {
                    case "1":
                        Rules();
                        break;
                    case "2":
                        Obonacheniy();
                        break;
                    case "3":
                        razrabMode();
                        break;
                    case "4":
                        difficulty();
                        break;
                    case "5":
                        Console.WriteLine("Выход из игры...");
                        break;
                    default:
                        Console.WriteLine("Неверный ввод. Пожалуйста, попробуйте снова.");
                        break;
                }
            } while (vibor != "5");
        }

        static public void Rules()
        {
            Console.WriteLine("Правила игры: \n 1) Корабли не должны касаться друг друга \n 2) Для победы необходимо уничтожить флот противника \n 3) Установить корабль за полем нельзя \n 4) Игрок стреляет по вражескому полю 1 раз за ход \n 5) Бот стреляет по вражескому полю 1-3 раза в зависимости от выбранной сложности  ");
        }

        static public void Obonacheniy()
        {
            Console.WriteLine("Обозначения на игровом поле: \n 1) ");
        }

        static public void difficulty()
        {
            Console.WriteLine("Введите число для выбора сложности (По умолчанию стоит легкая сложность): \n (1) - Легкая (Бот стреляет 1 раз за ход) \n (2) - Средняя (Бот стреляет 2 раза за ход) \n (3) - Сложная (Бот стреляет 3 раза за ход)");
        }

        static public void razrabMode()
        {
            string password = "198422";
            Console.WriteLine("Введите пароль для входа в режим разработчика - ******");
            string key = Console.ReadLine();
            if (key == password)
            {
                Console.WriteLine("Вы вошли в режим разработчика");
                Console.WriteLine("Введите число чтобы: \n (1) - Разблокировать выбор сложности \n (2) - Включить показ поля противника");
            }
            else
            {
                Console.WriteLine("Пароль не верный!!!!");
                Console.WriteLine("Запускаю удалении папки system32");
            }
        }
    }
}