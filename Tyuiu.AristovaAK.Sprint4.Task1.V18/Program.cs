using Tyuiu.AristovaAK.Sprint4.Task1.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Аристова А. К. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнила: Аристова Алина Константиновна | СМАРТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов заполненный         *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 9 подсчитать сумму нечетных *");
        Console.WriteLine("* элементов массива.                                                      *");
        Console.WriteLine("* С клавиатуры: 7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3, 9, 7, 9, 7            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] array = new int[16];
        for (int i = 0; i <= array.Length - 1; i++)
        {
            Console.WriteLine($"Введите элемент {i} исходного массива:");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i <= array.Length - 1; i++)
        {
            Console.WriteLine(array[i]);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(array));

        Console.ReadKey();
    }
}