// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint4.Task1.V23.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
int len;
Console.WriteLine("Введите количество элементов массива: ");
len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
for (int i = 0; i < len; i++)
{
    Console.WriteLine("Введите значение " + i + " элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0; i < len; i++)
{
    Console.Write(array[i] + "\t");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(array);
Console.WriteLine("Сумма четных элементов массива: " + res);
Console.ReadKey();
