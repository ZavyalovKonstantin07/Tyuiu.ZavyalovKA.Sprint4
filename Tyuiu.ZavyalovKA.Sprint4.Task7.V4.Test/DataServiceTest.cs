using Newtonsoft.Json.Linq;
using Tyuiu.ZavyalovKA.Sprint4.Task7.V4.Lib;
namespace Tyuiu.ZavyalovKA.Sprint4.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 4;
            string value = "382976421897";
            int res = ds.Calculate(n, m, value);
            int wait = 36; 
            Assert.AreEqual(wait, res);
        }
    }
}
