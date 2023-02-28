/*Написать программу, которая из имеющегося массива строк формирует массив из строк,
длинна которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine()!);
string[] array = new string[n];
string[] nextArray = new string[n];

Console.WriteLine();
EnterElements(n);
Console.ReadKey();

Console.WriteLine();

void EnterElements(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите  слово или символ :  ");
        array[i] = Console.ReadLine()!;
    }
    Console.ReadKey();
    Console.WriteLine();
    Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
}