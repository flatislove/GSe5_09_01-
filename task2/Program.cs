//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
    Random random = new Random();
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result.SetValue(random.Next(min, max + 1), i);
    }
    return result;
}
int SumOfUnevenPositions(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }

    }
    return sum;
}
Console.Clear();
int[] array = GetArray(ReadNumber(), -20, 20);
Console.WriteLine(String.Join("*", array));
Console.WriteLine($"Сумма чисел на нечетных позициях = {SumOfUnevenPositions(array)}");
