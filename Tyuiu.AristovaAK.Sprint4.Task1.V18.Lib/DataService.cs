using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AristovaAK.Sprint4.Task1.V18.Lib
{
    public class DataService : ISprint4Task1V18
    {
        public int Calculate(int[] array)
        {
            int s = 0;
            foreach (int i in array)
            {
                if (i % 2 != 0) s += i;
            }
            return s;
        }
    }
}
