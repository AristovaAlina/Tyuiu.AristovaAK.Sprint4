using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AristovaAK.Sprint4.Task6.V5.Lib
{
    public class DataService : ISprint4Task6V5
    {
        public int Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, item => item.Length == 5);
            return res.Length;
        }
    }
}
