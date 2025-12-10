using Tyuiu.AristovaAK.Sprint4.Task0.V16.Lib;
namespace Tyuiu.AristovaAK.Sprint4.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[] nums = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            int res = 3072;
            Assert.AreEqual(res, ds.GetMultEvenArrEl(nums));

        }
    }
}
