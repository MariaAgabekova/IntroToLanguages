void Zadacha64()
{
    // Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
    // который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
    Console.WriteLine("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int counter = m;
    Console.WriteLine($"Числа в отрезке от {m} до {n}, кратные 3:");
    FindDiv3(n, counter);
}
Zadacha64();

void FindDiv3(int n, int counter)
{
    if (counter % 3 == 0)
    {
        Console.WriteLine(counter);
    }
    if (counter < n)
    {
        counter++;
    }
    else
    {
        return;
    }
    FindDiv3(n, counter);
}
