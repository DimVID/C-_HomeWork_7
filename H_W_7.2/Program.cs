//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using static System.Console;
Clear();

Console.Write("Введите номер строки искомого элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца искомого элемента: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int n = 4;
int m = 4;
Random random = new Random();
int[,] array = new int[n, m];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 10);
        Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
}
if (row < 0 | row > array.GetLength(0) | col < 0 | col > array.GetLength(1))
{
    Console.WriteLine();
    Console.WriteLine("Заданного элемента не существует в массиве");
}
else
{
    Console.WriteLine();
    Console.WriteLine($"Заданный элемента массива = {array[row, col]}");
}
