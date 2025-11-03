// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint4.Task4.V16.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];
Console.WriteLine("***************************************************************************");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"Введите элемент массива [{i},{j}]: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("\nМассив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
Console.WriteLine("******************************************************************************");

int[,] res = ds.Calculate(matrix);
Console.WriteLine("Массив, где чётные числа заменены единицами:");
for (int i = 0; i < res.GetLength(0); i++)
{
    for (int j = 0; j < res.GetLength(1); j++)
    {
        Console.Write($"{res[i, j]}\t");
    }
    Console.WriteLine();
}

Console.ReadKey();
