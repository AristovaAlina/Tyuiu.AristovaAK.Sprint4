using System.ComponentModel.DataAnnotations;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AristovaAK.Sprint4.Task0.V16.Lib
{
    public class DataService : ISprint4Task0V16
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int res = 1;
            foreach (int i in array)
            {
                if (i % 2 == 0) res *= i;
            }
            return res;
        }
    }
}