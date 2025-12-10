using Tyuiu.AristovaAK.Sprint4.Task2.V5.Lib;
namespace Tyuiu.AristovaAK.Sprint4.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 3, 4, 5, 6, 7, 3, 4, 5, 6, 7, 3, 4, 5, 6 };
            int wait = 13824;
            Assert.AreEqual(wait, ds.Calculate(array));
        }
    }
}
