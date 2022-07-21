// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов
//Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 
Console.WriteLine("задача 56");
Console.Write("задайте количество строк массива: ");
int NumberOfLines = Convert.ToInt32(Console.ReadLine());
Console.Write("задайте количество столбцов массива: ");
int NumberOfColumns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[NumberOfLines, NumberOfColumns];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
int[] newArray = new int[NumberOfLines];
for (int i = 0; i < NumberOfLines; i++)
{
    int summ = 0;
    for (int a = 0; a < NumberOfLines; a++)
    {
        summ = summ + array[i, a];
    }
    newArray[i] = summ;
}
int min = newArray[0];
int stroka = 0;
for (int b = 0; b < NumberOfLines; b++)
{
    if (newArray[b] < min)
    {
        min = newArray[b];
        stroka = b;
    }
}
Console.WriteLine("строка " + (stroka + 1));






