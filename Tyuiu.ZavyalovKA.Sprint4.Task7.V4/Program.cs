// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint4.Task7.V4.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int n = 3;
int m = 4;
string value = "382976421897";
int[,] matrix = new int[n, m];
Console.WriteLine("\nМассив: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = int.Parse(value[i * m + j].ToString());
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(n, m, value);
Console.WriteLine("Сумма нечетных чисел в матрице: " + res);
Console.ReadKey();

