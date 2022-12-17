void Zadacha66()
{
    // Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму 
    //натуральных элементов в промежутке от M до N.
    Console.WriteLine("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = SumElements(m, n);
    Console.Write($"Сумма элементов равна {sum}");
}
Zadacha66();

int SumElements(int m, int n)
{
    int sum = 0;
    if (m == n)
    {
        Console.WriteLine($"Сумма элементов в промежутке равна {m}");
        return m;
    }

    if (m < n)
    {
        while (m <= n - 1)
        {
            Console.Write($"{m}, ");
            sum = sum + m;
            m++;
        }
        if (m == n)
        {
            Console.WriteLine($"{m}");
            sum = sum + m;
        }
    }

    if (n < m)
    {
        while (n <= m - 1)
        {
            Console.Write($"{n}, ");
            n++;
            sum = sum + n;
        }
        if (n == m)
        {
            Console.WriteLine($"{n}");
            sum = sum + n;
        }
    }
    return sum;
}

