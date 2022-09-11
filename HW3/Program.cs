// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212->нет
// 12821 -> да

Console.WriteLine("enter a five - digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberToString = Convert.ToString(number);
if (numberToString.Length == 5)
{
    if ((numberToString[0] == numberToString[4]) && (numberToString[1] == numberToString[3]))
    {
        Console.WriteLine("the number IS a palindrome ");
    }
    else Console.WriteLine("the number NOT is a palindrome ");
}
else Console.WriteLine("the number NOT a five - digit number ");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84

Console.WriteLine("enter the coordinate x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the coordinate y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the coordinate x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the coordinate y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the coordinate z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the coordinate z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"distance between points: {Math.Round(d, 3)}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27


Console.WriteLine("enter a number: ");
int end = Convert.ToInt32(Console.ReadLine());

for (int start = 1; start <= end; start++)
{
    Console.WriteLine($"a number: {start* start* start}");
}
