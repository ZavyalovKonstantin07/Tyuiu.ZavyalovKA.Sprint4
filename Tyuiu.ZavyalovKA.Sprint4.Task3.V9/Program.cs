// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint4.Task3.V9.Lib;
int[,] array = {  {9, 6, 4, 5, 3 },
                              {7, 4, 7, 5, 3 },
                              {8, 5, 9, 9, 3 },
                              {7, 8, 7, 9, 3 },
                              {3, 7, 3, 7, 7 } };
int rows = array.GetLength(0);
int columns = array.GetLength(1);
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Массив = ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{ array[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(array);
Console.WriteLine("Сумма элементов во втором столбце массива " + res);
Console.ReadKey();

