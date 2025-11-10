// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint4.Task6.V26.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
var array = new string[] { "Тюмень", "Тамбов", "Томск", "Омск", "Орёл" };
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Элементы, длина которых больше 5 символов: ");

string[] a = ds.Calculate(array);
foreach (string item in a)
{
    Console.WriteLine(item);
}

Console.ReadKey();

