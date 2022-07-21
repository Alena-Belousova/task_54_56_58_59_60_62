// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

Console.WriteLine("задача 58");
Console.Write("задайте количество строк матрицы 1: ");
int NumberOfLines1 = Convert.ToInt32(Console.ReadLine());
Console.Write("задайте количество столбцов матрицы 1: ");
int numberofcolumns1 = Convert.ToInt32(Console.ReadLine());
int NumberOfLines2 = NumberOfLines1;
int numberofcolumns2 = numberofcolumns1;
int[,] array1 = new int[NumberOfLines1, numberofcolumns1];

for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        array1[i, j] = new Random().Next(1, 10);
        Console.Write(array1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] array2 = new int[NumberOfLines2, numberofcolumns2];

for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = new Random().Next(1, 10);
        Console.Write(array2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] result = new int[NumberOfLines1, numberofcolumns1];
for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        result[i, j] = array1[i, j] * array2[i, j];
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
