using Tyuiu.ZavyalovKA.Sprint4.Task5.V2.Lib;
namespace Tyuiu.ZavyalovKA.Sprint4.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] matrix = { { -1, 2, 3 }, { -2, 3, 5 } };
            int res = ds.Calculate(matrix);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
