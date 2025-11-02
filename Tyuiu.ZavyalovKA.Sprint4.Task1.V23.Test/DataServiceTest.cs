using Tyuiu.ZavyalovKA.Sprint4.Task1.V23.Lib;
namespace Tyuiu.ZavyalovKA.Sprint4.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] array = { 9, 9, 5, 6, 5, 4, 4, 5, 8, 7, 6, 8, 7, 5, 9, 9, 9 };
            int res = ds.Calculate(array);
            int wait = 36;
            Assert.AreEqual(wait, res);
        }
    }
}
