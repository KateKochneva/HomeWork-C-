// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int count = 0;

FillInTheArray(array);           

for (int a = 0; a < array.Length; a++)
{
if (array[a] % 2 == 0) count++;
}


Console.WriteLine($"total {array.Length} numbers, {count}  - even numbers");


void FillInTheArray(int[] array1)
    {
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = new Random().Next(100, 1000);
            Console.WriteLine(array1[i]);
        }              
    }


 // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19

Console.WriteLine("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int sum = 0;

FillInTheArray(array);

for (int a = 0; a < array.Length; a++)
{
    if (a % 2 != 1)
    sum = sum + array[a];  
}

Console.WriteLine($"total {sum} numbers");

void FillInTheArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 11);
        Console.WriteLine(array[i]);
    }
}




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.WriteLine("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

FillInTheArray(array);

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
  {
    if (max < array[i]) max = array[i];
    if (min > array[i]) min = array[i];
  }
 

double decision = max - min;

Console.WriteLine($"total {decision} numbers {max} {min}");

void FillInTheArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(1,11));
        Console.WriteLine(array[i]);
    }
}