/*Написать программу, которая из имеющегося массива строк формирует массив из строк,
длинна которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/
Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine()!);
string[] array = new string[n];
string[] nextArray = new string[n];

Console.WriteLine();
EnterElements(n);
Console.ReadKey();
SelectArray(array, nextArray);
Console.WriteLine();
PintArray(nextArray);
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

void SelectArray(string[] array, string[] nextArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; ++i)
        if (i % 2 != 0)
        {
            nextArray[count] = array[i];
            count++;
        }
    if (count > 3) return;
}

void PintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{nextArray[i]} \t ");
    }
    Console.WriteLine();
}
