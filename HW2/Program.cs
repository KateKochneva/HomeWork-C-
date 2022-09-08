// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
Console.WriteLine("Enter: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string num2 = Convert.ToString(num);

    Console.WriteLine(num2[1]);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78->третьей цифры нет
//32679-> 6

Console.WriteLine("Enter: ");
int num = Convert.ToInt32(Console.ReadLine());
string num2 = Convert.ToString(num);

if (num2.Length == 3)
{
    Console.WriteLine(num2[2]);
}
else Console.WriteLine("ERROR");

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6->да
//7->да
//1->нет

Console.WriteLine("Enter number of day: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.WriteLine("It is weekend");
}