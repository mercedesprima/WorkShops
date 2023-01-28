// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int matrixRows = 5;
int matrixColumns = 5;
int matrixMinValue = 1;
int matrixMaxValue = 10;

int[,] firstMatrix = CreateMatrix(matrixRows, matrixColumns, matrixMinValue, matrixMaxValue);
PrintMatrix(firstMatrix);
Console.WriteLine();
int[] firstArray = NumberDictionary(firstMatrix);
PrintArray(firstArray);
Console.WriteLine();
Array.Sort(firstArray);
PrintArray(firstArray);
Console.WriteLine();
Dictionary(firstArray);


int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}   ");
        }
        Console.WriteLine($"]", 4);
    }
}

int[] NumberDictionary(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[index] = matrix[i, j];
            index++;
        }
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void Dictionary(int[] array)
{
    int number = array[0];
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) count++;
        else
        {
            Console.WriteLine($"{number} -> {count}");
            number = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{number} -> {count}");
}