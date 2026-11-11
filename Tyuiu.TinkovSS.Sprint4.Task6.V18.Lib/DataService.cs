using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TinkovSS.Sprint4.Task6.V18.Lib
{
    public class DataService : ISprint4Task6V18
    {
        public string[] Calculate(string[] array)
        {
            // Используем метод Array.FindAll для фильтрации элементов длиннее 6 символов
            string[] res = Array.FindAll(array, str => str.Length > 6);
            return res;
        }
    }
}