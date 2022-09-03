//Задайте одномерный массив, заполненный случайными числами. Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. 
//Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних арифметических.

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
double AverageArray(int[] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum / array.Length;
}
int GetSizeArray(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
void PrintResult(double averageArrayEven, double averageArrayUneven)
{
    if (averageArrayEven > averageArrayUneven || (Double.IsNaN(averageArrayUneven) && !Double.IsNaN(averageArrayEven)))
    {
        Console.WriteLine($"Среднее четных больше. {averageArrayEven}>{averageArrayUneven}");

    }
    else if (averageArrayEven < averageArrayUneven || (Double.IsNaN(averageArrayEven) && !Double.IsNaN(averageArrayUneven)))
    {

        Console.WriteLine($"Среднее нечетных больше. {averageArrayEven}<{averageArrayUneven}");
    }
    else if (averageArrayEven == averageArrayUneven || (Double.IsNaN(averageArrayEven) && Double.IsNaN(averageArrayUneven)))
    {
        Console.WriteLine($"Средние четных и нечетных равны. {averageArrayEven}={averageArrayUneven}");
    }
}

void CreateArrays(int[] array, int[] arrayEven, int[] arrayUneven)
{
    int counterEven = 0;
    int counterUneven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            arrayEven[counterEven] = array[i];
            counterEven++;
        }
        else
        {
            arrayUneven[counterUneven] = array[i];
            counterUneven++;
        }
    }
}

Console.Clear();

int[] array = GetArray(ReadNumber(), 0, 10);
int[] arrayEven = new int[GetSizeArray(array)];
int[] arrayUneven = new int[array.Length - arrayEven.Length];
CreateArrays(array, arrayEven, arrayUneven);
Console.WriteLine("Массив начальный: " + String.Join(" ", array));
Console.WriteLine("Массив четных: " + String.Join(" ", arrayEven));
Console.WriteLine("Массив нечетных: " + String.Join(" ", arrayUneven));
PrintResult(Math.Round(AverageArray(arrayEven), 2), Math.Round(AverageArray(arrayUneven), 2));