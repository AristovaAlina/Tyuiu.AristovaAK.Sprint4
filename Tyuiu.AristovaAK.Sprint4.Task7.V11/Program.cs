using Tyuiu.AristovaAK.Sprint4.Task7.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Аристова А. К. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнила: Аристова Алина Константиновна | СМАРТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр '56789012'. Преобразуйте ее в матрицу *");
        Console.WriteLine("* 4 на 2 и подсчитайте количество нечетных чисел в матрице.               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int n = 4;
        int m = 2;
        string str = "56789012";
        Console.WriteLine("Количество строк: " + n);
        Console.WriteLine("Количество столбцов: " + m);
        Console.WriteLine("Исходная строка: " + str);

        Console.WriteLine("Массив:");
        for (int i  = 0; i < n; i++)
        {
            for (int j = 0;  j < m; j++)
            {
                Console.Write($"{str[i * m + j], -3}");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Количество нечетных чисел в матрице: " + ds.Calculate(n, m, str));

        Console.ReadKey();
    }
}