void Zadacha56()
{
    /*
    Задача 56. Задайте прямоугольный двумерный массив. 
    Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    */
    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(3);
            Console.Write(array[i, j] + "\t");

        }
        Console.WriteLine();
    }
    int minRowSum = int.MaxValue;
    int indexMinRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int Sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Sum += array[i, j];
        }
        if (Sum < minRowSum)
        {
            minRowSum = Sum;
            indexMinRow = i;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов => {indexMinRow + 1}");
}
Zadacha56();