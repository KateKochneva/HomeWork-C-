// Задача: Пользователь вводит с клавиатуры 3 массива строк. Для каждого сформировать новый массив, где длина меньше или равна 3 символам

Console.WriteLine("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];


string[] arrayCopy = new string[size];

FillInTheArray(array);

for (int a = 0; a < array.Length; a++)
{
    if (array[a].Length <= 3)
    {                 
        arrayCopy[a] = array[a];
    }
}


for (int i = 0; i < arrayCopy.Length; i++)
{
    Console.WriteLine(arrayCopy[i]);
}


void FillInTheArray(string[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = Console.ReadLine();
    }
}
