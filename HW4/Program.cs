// Задача 25: Напишите цикл, который принимает на вход два числа(A и B) и возводит число A в натуральную степень B.
// 3, 5-> 243(3⁵)
// 2, 4-> 16

Console.WriteLine("Enter number 1: ");
int number1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter number 2: ");
int number2 = Int32.Parse(Console.ReadLine());
int number3 = 1;

for (int i = 0; i < number2; i++)
{

    number3 = number3 * number1;

}
Console.WriteLine($"sqr: {number3}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11

Console.WriteLine("Enter: ");
string number = Console.ReadLine();
int sum = 0;

for (int i = 0; i < number.Length; i++)
{                
    sum = sum + int.Parse(number[i].ToString());

}


Console.WriteLine($"Sum: {sum}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]


Console.WriteLine("Enter size of array: ");

int n = Int32.Parse(Console.ReadLine()); //Переменная которая задает размер массива
int[] array = new int[n]; //Задаем размер массива
for (int i = 0; i < n; i++) //Присваиваем значение каждой ячейки массива
{
    Console.WriteLine("Enter array: ");
    int k = Int32.Parse(Console.ReadLine()); // Значение задавать здесь
    array[i] = k;               
}

foreach (int r in array)
    Console.WriteLine(r);
Console.ReadKey();


