using Tyuiu.ZavyalovKA.Sprint4.Task6.V26.Lib;
namespace Tyuiu.ZavyalovKA.Sprint4.Task6.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var array = new string[] { "Тюмень", "Тамбов", "Томск", "Омск", "Орёл" };
            string[] res = ds.Calculate(array); 
            var wait = new string[] { "Тюмень", "Тамбов" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
