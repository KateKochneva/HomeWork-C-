// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int count = 0;

FillInTheArray(array);           

for (int a = 0; a < array.Length; a++)
{
if (array[a] > 0) count++;
}


Console.WriteLine($"total {array.Length} numbers, {count}  - more tnan 0");


void FillInTheArray(int[] array1)
    {
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = Convert.ToInt32(Console.ReadLine());           
        }              
    }



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Enter 4 numbers: b1, k1, b2, k2 ");
int[] array = new int[4];
array[0] = Convert.ToInt32(Console.ReadLine());
array[1] = Convert.ToInt32(Console.ReadLine());
array[2] = Convert.ToInt32(Console.ReadLine());
array[3] = Convert.ToInt32(Console.ReadLine());

int b1 = array[0];
int k1 = array[1];
int b2 = array[2];
int k2 = array[3];

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");