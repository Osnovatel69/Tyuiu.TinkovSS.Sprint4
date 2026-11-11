using System;
using Tyuiu.TinkovSS.Sprint4.Task0.V30.Lib;

namespace Tyuiu.TinkovSS.Sprint4.Task0.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Тиньков С.С.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Тиньков С.С.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму          *");
            Console.WriteLine("* четных элементов массива. {9, 8, 4, 6, 9, 4, 3, 6, 1, 2}               *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };

            Console.WriteLine("Исходный массив: {" + string.Join(", ", array) + "}");

            int res = ds.GetSumEvenArrEl(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма четных элементов массива = " + res);

            Console.ReadKey();
        }
    }
}