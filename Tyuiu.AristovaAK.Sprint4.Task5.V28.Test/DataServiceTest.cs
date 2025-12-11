using Tyuiu.AristovaAK.Sprint4.Task5.V28.Lib;
namespace Tyuiu.AristovaAK.Sprint4.Task5.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix =
            {
                { -6, 2, 2, 0, -4 },
                { 1, -2, -1, 2, 1 },
                { -5, 2, 0, -5, -3 },
                { -2, 2, 2, -2, 2 },
                { 1, 2, 0, -3, 2 },
            };

            int[,] res =
            {
                { 0, 2, 2, 0, 0 },
                { 1, 0, 0, 2, 1 },
                { 0, 2, 0, 0, 0 },
                { 0, 2, 2, 0, 2 },
                { 1, 2, 0, 0, 2 },
            };

            CollectionAssert.AreEqual(res, ds.Calculate(matrix));
        }
    }
}
