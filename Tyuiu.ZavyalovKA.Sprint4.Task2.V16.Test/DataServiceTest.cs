using Tyuiu.ZavyalovKA.Sprint4.Task2.V16.Lib;
namespace Tyuiu.ZavyalovKA.Sprint4.Task2.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] array = { 1, 2, 3, 4, 5 };
            int res = ds.Calculate(array);
            int wait = 9;
            Assert.AreEqual(wait, res);
        }
    }
}
