// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("задача 54");
Console.Write("задайте количество строк массива: ");
int NumberOfLines = Convert.ToInt32(Console.ReadLine());
Console.Write("задайте количество столбцов массива: ");
int numberofcolumns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[NumberOfLines, numberofcolumns];
int j=0;
int i = 0;
for ( i = 0; i < array.GetLength(0); i++)
{
    for ( j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine(); 
    
}Console.WriteLine();

// Идём по строкам
for (i = 0; i < array.GetLength(0); i++) {
    // Для каждой строки создаём временный одномерный массив
    int[] newArray = new int[array.GetLength(1)];
    // Заполняем новый массив значениями из строчки оригинального
    for (j = 0; j < array.GetLength(1); j++) {
        newArray[j] = array[i,j];
    }
    // Сортируем новый массив
    Array.Sort(newArray);
    // Заполняем строку оригинального массива значениями из нового
    // Заодно выводим на экран
    for (j = 0; j < array.GetLength(1); j++) {
        array[i,j] = newArray[j];
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

   
    
   

