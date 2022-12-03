void Zadacha38()
{
    /*
    Задача 38: Задайте массив вещественных чисел. 
    Найдите разницу между максимальным и минимальным элементов массива.
    [3,21 7,04 22,93 -2,71 78,24] -> 80,95
    */
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] numbers = new double[size];
    FillArray(numbers);
    Console.Write("Задан массив: ");
    PrintArray(numbers);
    double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
        else if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    Console.WriteLine($"Разница между max и min числами массива => {max} - {min} = {max - min}");

    void FillArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
        }
    }

    void PrintArray(double[] array)
    {
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}
Zadacha38();