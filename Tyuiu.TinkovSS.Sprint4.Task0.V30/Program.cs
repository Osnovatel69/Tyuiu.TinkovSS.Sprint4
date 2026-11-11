using Tyuiu.TinkovSS.Sprint4.Task0.V30.Lib;

Console.Title = "Спринт #4 | Выполнил: Тиньков С. С. | ИИПБ-25-1";

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #30                                                             *");
Console.WriteLine("* Выполнил: Тиньков Степан Сергеевич | ИИПБ-25-1                          *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать сумму         *");
Console.WriteLine("* четных элементов массива.                                               *");
Console.WriteLine("* {9, 8, 4, 6, 9, 4, 3, 6, 1, 2}                                          *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };

Console.WriteLine("Исходный массив: " + string.Join(", ", array));

DataService ds = new DataService();
int result = ds.Calculate(array);

Console.WriteLine("Сумма четных элементов массива = " + result);

Console.ReadKey();
