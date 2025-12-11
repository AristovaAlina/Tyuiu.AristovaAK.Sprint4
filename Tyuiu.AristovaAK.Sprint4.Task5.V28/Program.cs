using System.Numerics;
using Tyuiu.AristovaAK.Sprint4.Task5.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Аристова А. К. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнила: Аристова Алина Константиновна | СМАРТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 6. Заменить нечетные        *");
        Console.WriteLine("* элементы массива на 0.                                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Random rnd = new Random();

        int[,] matrix = new int[5, 5];
        for (int i = 0;  i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(-6, 3);
                Console.Write($"{matrix[i, j],3}");
            }
            Console.WriteLine();
        }

        Console.WriteLine("");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int[,] res = ds.Calculate(matrix);
        for (int i1 = 0; i1 < res.GetLength(0); i1++)
        {
            for (int j1 = 0; j1 < res.GetLength(1); j1++)
            {
                Console.Write($"{res[i1, j1], 3}");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}