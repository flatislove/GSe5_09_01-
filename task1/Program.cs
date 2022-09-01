//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int ReadNumber()
{
    int number = 0;
    while (true)
    {
        Console.WriteLine("Введите размерность массива");
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Некорректный ввод");
        }
        else break;
    }
    return number;
}
int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result.SetValue(new Random().Next(min, max + 1), i);
    }
    return result;
}
int CountEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int x in array)
    {
        if (x % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Clear();

int[] array = GetArray(ReadNumber(), 100, 999);
Console.WriteLine(String.Join("*", array));
Console.WriteLine($"Количество четных чисел = {CountEvenNumbers(array)}");