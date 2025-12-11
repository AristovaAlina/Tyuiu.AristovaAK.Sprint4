using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AristovaAK.Sprint4.Task3.V30.Lib
{
    public class DataService : ISprint4Task3V30
    {
        public int Calculate(int[,] matrix)
        {
            int max = int.MinValue;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[2, i] > max) max = matrix[2, i];
            }
            return max;
        }
    }
}
