using Tyuiu.AristovaAK.Sprint4.Task6.V5.Lib;
namespace Tyuiu.AristovaAK.Sprint4.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] planets = { "Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун" };
            int res = 1;
            Assert.AreEqual(res, ds.Calculate(planets));
        }
    }
}
