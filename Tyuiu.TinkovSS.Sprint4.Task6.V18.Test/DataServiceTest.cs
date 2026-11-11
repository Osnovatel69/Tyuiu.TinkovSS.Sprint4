using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint4.Task6.V18.Lib;

namespace Tyuiu.TinkovSS.Sprint4.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] animals = { "Собака", "Кошка", "Кролик", "Хомяк", "Попугай", "Рыбка", "Черепаха" };
            string[] res = ds.Calculate(animals);

            // Больше 6 символов: "Попугай" (7) и "Черепаха" (8)
            string[] wait = { "Попугай", "Черепаха" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}