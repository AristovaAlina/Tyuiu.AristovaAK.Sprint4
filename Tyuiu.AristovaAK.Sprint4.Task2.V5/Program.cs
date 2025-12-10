using Tyuiu.AristovaAK.Sprint4.Task2.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Аристова А. К. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнила: Аристова Алина Константиновна | СМАРТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
        Console.WriteLine("* случайными в диапазоне от 3 до 9 подсчитать произведение четных         *");
        Console.WriteLine("* элементов массива.                                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Random rnd = new Random();
        int[] array = new int[14];

        for (int i = 0; i <= array.Length - 1; i++)
        {
            array[i] = rnd.Next(3, 9);
        }

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i <= array.Length - 1; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine("");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(array));

        Console.ReadKey();
    }
}