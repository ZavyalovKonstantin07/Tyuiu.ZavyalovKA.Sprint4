// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint4.Task2.V16.Lib;
Random rnd = new Random();
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.Write("Введите количество элементов массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
for (int i = 0; i < len; i++)
{
    array[i] = rnd.Next(2, 9);
}
Console.WriteLine("Массив: ");
for (int i = 0; i < len; i++)
{
    Console.WriteLine(array[i] + "\t");
}
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(array);
Console.WriteLine("Сумма нечётных элементов массива = " + res);
Console.ReadKey();