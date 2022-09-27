// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 - 2 - 0,2
// 1 - 3,3 8 - 9,9
// 8 7,8 - 7,1 9

Console.WriteLine("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[rows, columns];
FillInTheArray(array);


void FillInTheArray(double[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

PrintArray(array);
void PrintArray(double[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write(array2[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}



// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

Console.WriteLine("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
FillInTheArray(array);
void FillInTheArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(-100, 100)) / 10;
        }
    }
}

PrintArray(array);
void PrintArray(int [,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write(array2[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine("Enter the first position of an element in a two-dimensional array: ");
int firstPosition = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second position of an element in a two-dimensional array: ");
int secondPosition = Convert.ToInt32(Console.ReadLine());

CheckArray(array, firstPosition, secondPosition);

void CheckArray(int [,] array, int firstPosition, int secondPosition)
{
    if (firstPosition > array.GetLength(0) || secondPosition > array.GetLength(1))
    {
        Console.WriteLine("did not find");
    }
    else
    {
        Console.WriteLine($"element value {firstPosition} raw and {secondPosition} the column is equal to {array[firstPosition - 1, secondPosition - 1]}");
    }
    
}



// Задача 52.Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
FillInTheArray(array);
void FillInTheArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(-100, 100)) / 10;
        }
    }
}

PrintArray(array);
void PrintArray(int [,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write(array2[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
FindArithmeticMean(array, rows);

void FindArithmeticMean(int [,] array, int rows){

for (int j = 0; j < array.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avarage = (avarage + array[i, j]);
        }
        avarage = avarage / rows;
        Console.Write((avarage + "; ");
    }
}
