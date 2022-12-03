void Zadacha36()
{
    /*
    Задача 36: Задайте одномерный массив, заполненный случайными 
    числами. Найдите сумму элементов с нечётными индексами.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
    */
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    FillArray(numbers);
    Console.Write("Задан массив: ");
    PrintArray(numbers);
    int sum = 0;

    for (int i = 1; i < numbers.Length; i += 2)
        sum = sum + numbers[i];

    Console.WriteLine($"Сумма элементов массива с нечётными индексами = {sum}");

    void FillArray(int[] array)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            array[i] = new Random().Next(-100, 101);
        }
    }
    void PrintArray(int[] array)
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
Zadacha36();