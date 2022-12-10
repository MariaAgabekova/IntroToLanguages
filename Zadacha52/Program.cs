void Zadacha52()
{
    /*
    Задача 52. Задайте двумерный массив из целых чисел. 
    Найдите среднее арифметическое элементов в каждом столбце.
    Например, задан массив:
    1 4 7 2
    5 9 5 3
    8 4 6 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.
    */
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(11);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Среднее арифметическое столбцов: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double avg = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        avg = sum / array.GetLength(0);
        Console.Write(Math.Round(avg, 2) + "\t");
    }
    Console.WriteLine();

}
Zadacha52();