/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7->max = 7
a = 2 b = 10->max = 10
a = -9 b = -3->max = -3
*/


Console.WriteLine("Введите 2 числа");
int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());

if (first != second)
{
    if (first > second)
    {

        Console.WriteLine($"Число {first} больше чем {second}");

    }
    else Console.WriteLine($"Число {second} больше чем {first}");
}




/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7-> 7
44 5 78-> 78
22 3 9-> 22
*/

Console.WriteLine("Введите 3 числа");
int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());
int max = first;


if (second > first) max = second;
if (third > max) max = third;


Console.WriteLine($"Число {max} набольшее");


/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число");
int count = int.Parse(Console.ReadLine());

if (count % 2 == 0)
{

Console.WriteLine("Четное YES");

}
else Console.WriteLine("NO");


/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число");
int first = int.Parse(Console.ReadLine());


if (first % 2 == 0)
{
    Console.WriteLine(first);


    while (first > 2)
    {

        first = first - 2;                  
        Console.WriteLine(first);
    }

}
else
{
    Console.WriteLine(first - 1);
    first = first - 1;


    while (first > 2)
    {

        first = first - 2;                   
        Console.WriteLine(first);
    }
}
