using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint4.Task2.V16.Lib;

namespace Tyuiu.TinkovSS.Sprint4.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            // Тестовый массив из 10 элементов в диапазоне от 2 до 9
            // Нечетные элементы: 3, 5, 7, 9, 3 -> Сумма: 3 + 5 + 7 + 9 + 3 = 27
            int[] numsArray = { 2, 3, 4, 5, 6, 7, 8, 9, 2, 3 };

            int res = ds.Calculate(numsArray);
            int wait = 27;

            Assert.AreEqual(wait, res);
        }
    }
}