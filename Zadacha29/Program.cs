void Zadacha29()
{
    //Задача 29: Напишите программу, которая задаёт массив из 8 
    //случайных целых чисел и выводит отсортированный по модулю массив.
    // -2, 1, -7, 5, 19 -> [1, -2, 5, -7, 19]
    // 6, 1, -33 -> [1, 6, -33]
    int[] array = new int[8];
    void FillArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-40, 40);
            Console.Write(array[i] + " ");
        }
    }
    FillArray();
    void selectionSort()
    {
        for (int i = 0; i < array.Length; i++)
        {
            int minPosition = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minPosition])
                {
                    minPosition = j;
                }
            }
        }
    }
    selectionSort();
    void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
        {
            Console.WriteLine(col[position]);
            position++;
        }
    }
}
Zadacha29();