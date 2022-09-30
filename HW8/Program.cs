//Задача 54: Задайте двумерный массив.Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
Console.WriteLine("Enter the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

FillArray(array);
void FillArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

Console.WriteLine();
Console.WriteLine("Array before: ");

PrintArray(array);
void PrintArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write(array1[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < array.GetLength(1) - 1; z++)
        {
            if (array[i, z] < array[i, z + 1]) 
            {
                int temp = 0;
                temp = array[i, z];
                array[i, z] = array[i, z + 1];
                array[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Array with ordered values: ");
PrintArray(array);
*/




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
Console.WriteLine("Enter the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

FillArray(array);
void FillArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

Console.WriteLine();
Console.WriteLine("Array: ");

PrintArray(array);
void PrintArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write(array1[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
int SumLineElements(int[,] array1, int i)
{
    int sumLine1 = array1[i, 0];
    for (int j = 1; j < array1.GetLength(1); j++)
    {
        sumLine1 += array1[i, j];
    }
    return sumLine1;
}

for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"\n{minSumLine + 1} - the row with the smallest amount ({sumLine}) elements ");


*/
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Enter the number of rows first array: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns first array: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[rows1, columns1];


Console.WriteLine("Enter the number of rows second array: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns second array: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
int[,] array2 = new int[rows2, columns2];


FillArray(array1);
FillArray(array2);
void FillArray(int[,] array3)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            array3[i, j] = new Random().Next(0, 10);
        }
    }
}


Console.WriteLine();
Console.WriteLine("Array 1 before: ");
PrintArray(array1);
Console.WriteLine("Array 2 before: ");
PrintArray(array2);
void PrintArray(int[,] array3)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            Console.Write(array3[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}



int[,] resultMatrix = new int[rows1, columns2];

for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            resultMatrix[i, j] = resultMatrix[i, j] + (array1[i, k] * array2[k, j]);
        }
    }
}

Console.WriteLine($"\nThe product of the first and second matrices:");
PrintArray(resultMatrix);