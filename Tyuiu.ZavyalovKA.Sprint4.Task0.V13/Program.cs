// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint4.Task0.V13.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
int[] array = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
Console.WriteLine("Исходный массив: ");
for (int i =0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int sum = ds.GetSumEvenArrEl(array);

Console.WriteLine("Сумма четных элементов массива: " + sum); 
Console.ReadKey();
   

