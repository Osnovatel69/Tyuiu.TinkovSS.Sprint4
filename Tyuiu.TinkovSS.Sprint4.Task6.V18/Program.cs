using System;
using Tyuiu.TinkovSS.Sprint4.Task6.V18.Lib;

namespace Tyuiu.TinkovSS.Sprint4.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Тиньков С. С. | ПКТб-2X-X";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Тиньков С. С. | ПКТб-2X-X                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных, используя класс Array, выведите элементы   *");
            Console.WriteLine("* массива, длина которых больше 6 символов.                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] animals = { "Собака", "Кошка", "Кролик", "Хомяк", "Попугай", "Рыбка", "Черепаха" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] res = ds.Calculate(animals);

            Console.WriteLine("Элементы, длина которых больше 6 символов:");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}