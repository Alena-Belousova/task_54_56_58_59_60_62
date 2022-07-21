// Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива. 
Console.WriteLine("задача 59");
Console.Write("задайте количество строк: ");
int numberLine = Convert.ToInt32(Console.ReadLine());
Console.Write("задайте количество столбцов: ");
int numberColumn = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[numberLine, numberColumn];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
int min_i = 0;
int min_j = 0;
int min = array[0, 0];
for (int i = 0; i < numberColumn; i++)
    for (int j = 0; j < numberLine; j++)
        if (array[i, j] < min)
        {
            min = array[i, j];
            min_i = i;
            min_j = j;
        }
Console.WriteLine("min= " + min + "[" + min_i + "," + min_j + "]");
Console.WriteLine();
int[,] array1 = new int[numberLine, numberColumn];
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        if (i != min_i && j != min_j)
        {
            array1[i, j] = array[i, j];
            Console.Write(array1[i, j] + " ");
        }
    }
    if (i != min_i)
    {
        Console.WriteLine();
    }
}







