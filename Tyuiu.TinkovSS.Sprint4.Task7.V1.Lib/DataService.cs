using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TinkovSS.Sprint4.Task7.V1.Lib
{
    public class DataService : ISprint4Task7V1
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Заполняем матрицу цифрами из строки: символ преобразуем в число
                    matrix[i, j] = int.Parse(value[i * m + j].ToString());

                    // Проверяем на четность
                    if (matrix[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}