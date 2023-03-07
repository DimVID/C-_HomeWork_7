// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
Clear();

Console.WriteLine("Введите количество строк массива, n =  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива, m = ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, m];
Console.WriteLine();
double[] sum = new double[m];
Random random = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = random.Next(1, 10);
        Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        sum[i] += array[j, i];
    }
}

for (int i = 0; i < m; i++)
{
    Console.WriteLine($"Среднее арифметическое столбцов: {sum[i] / n:f1}");
}
