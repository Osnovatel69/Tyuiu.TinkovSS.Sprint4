using System;
using Tyuiu.TinkovSS.Sprint4.Task0.V30.Lib;

namespace Tyuiu.TinkovSS.Sprint4.Task0.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Тиньков С. С. | ПКТб-2X-X";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Тиньков С. С. | ПКТб-2X-X                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9.                          *");
            Console.WriteLine("* Подсчитать сумму четных элементов массива.                              *");
            Console.WriteLine("* {9, 8, 4, 6, 9, 4, 3, 6, 1, 2}                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.GetSumEvenArrEl(numsArray);

            Console.WriteLine("Сумма четных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}