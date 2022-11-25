void Zadacha23()
{
    //Задача 23. Напишите программу, которая принимает на вход 
    //число (N) и выдаёт таблицу кубов чисел от 1 до N.
    // 3 -> 1, 8, 27
    // 5 -> 1, 8, 27, 64, 125
    Random rand = new Random();
    int N = rand.Next(1, 20);
    Console.WriteLine("Введено число: " + N);
    int result = 1;
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i} ^ 3 = {i * i * i}");
        Console.WriteLine();
    }
}
Zadacha23();
