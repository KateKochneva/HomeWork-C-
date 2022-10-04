// Задача 64: Задайте значение N.Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5-> "5, 4, 3, 2, 1"
// N = 8-> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
Console.WriteLine(NaturalNumbers(n, m));

int NaturalNumbers(int n1, int m1)
{
    if (n1 == m1)
        return n1;
    else
        Console.Write($"{NaturalNumbers(n1, m1 + 1)}, ");
    return m1;
}

//Задача 66: Задайте значения M и N.Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Enter N and M: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(NaturalNumbers(m, n));

int NaturalNumbers(int m1, int n1)
{
    if (n1 == m1) return n1;
    
    return n1 + NaturalNumbers(m1, n1 - 1);

}


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29

Console.WriteLine("Enter N and M: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");


int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}



