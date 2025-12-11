using Tyuiu.AristovaAK.Sprint4.Task7.V11.Lib;
namespace Tyuiu.AristovaAK.Sprint4.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int n = 4;
            int m = 2;
            string str = "56789012";
            int wait = 4;
            Assert.AreEqual(wait, ds.Calculate(n, m, str));
        }
    }
}
