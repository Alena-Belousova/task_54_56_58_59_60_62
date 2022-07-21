//Заполните спирально массив 4 на 4
Console.WriteLine("задача 62");
int size = 4;
int[,] array = new int[size, size];
int i = 0;
int j = 0;
int left = 0;
int up = 0;
int right = size - 1;
int down = size - 1;
int a =1;
array[0, 0] = 1;
while (right >= left && down >= up)
{
    if (j == up && i < right)
    {
        i++;
        if (i + j == size - 1)
            up++;
    }
    else if (i == right && j < down)
    {
        j++;
        if (i == j) right--;
    }
    else if (j == down && i > left)
    {
        i--;
        if (i + j == size - 1) down--;
    }
    else if (i == left && j > up)
    {
        j--;
        if (i == j - 1) left++;
    }
    array [j,i]= ++a;
    printArray(array);
}
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}