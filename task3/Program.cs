//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int ReadNumber(string message)
{
    int number = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Некорректный ввод");
        }
        else break;
    }
    return number;
}

double[] GetArray(int size, double min, double max)
{
    Random random = new Random();
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result.SetValue(Math.Round(min + random.NextDouble() * (max - min), 2), i);
    }
    return result;
}

double[] ManualInputArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент#" + Convert.ToInt32(i) + " = ");
        if (!double.TryParse(Console.ReadLine(), out array[i]))
        {
            i--;
            Console.WriteLine("Некорректный ввод");
        }
    }
    return array;
}

void Router(int direction)
{
    if (direction == 1)
    {
        PrintResult(GetArray(ReadNumber("Введите размерность массива "), -10, 10));
    }
    else if (direction == 2)
    {
        PrintResult(ManualInputArray(ReadNumber("Введите размерность массива")));
    }
    else Console.WriteLine("Некорректный ввод");
}

void PrintResult(double[] array)
{
    Console.WriteLine(String.Join("   ", array));
    Console.WriteLine($"Разница max-min = {Math.Round(array.Max() - array.Min(), 2)}");
}

Console.Clear();

Router(ReadNumber("Нажмите: 1-случайные числа; 2-ручной ввод"));