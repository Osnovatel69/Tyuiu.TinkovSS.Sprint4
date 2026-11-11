using System;
using Tyuiu.TinkovSS.Sprint4.Task7.V1.Lib;

namespace Tyuiu.TinkovSS.Sprint4.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Тиньков С. С. | ПКТб-2X-X";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Тиньков С. С. | ПКТб-2X-X                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"135792468\". Преобразуйте ее         *");
            Console.WriteLine("* в матрицу 3 на 3 и подсчитайте количество четных чисел.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 3;
            int columns = 3;
            string str = "135792468";

            Console.WriteLine($"Количество строк: {rows}");
            Console.WriteLine($"Количество столбцов: {columns}");
            Console.WriteLine($"Исходная строка: {str}");

            Console.WriteLine("\nМатрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[i * columns + j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(rows, columns, str);

            Console.WriteLine($"Количество четных чисел = {res}");

            Console.ReadKey();
        }
    }
}