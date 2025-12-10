using Tyuiu.AristovaAK.Sprint4.Task1.V18.Lib;
namespace Tyuiu.AristovaAK.Sprint4.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3, 9, 7, 9, 7 };
            int wait = 79;
            Assert.AreEqual (wait, ds.Calculate (array));
        }
    }
}
