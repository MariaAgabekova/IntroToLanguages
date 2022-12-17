void Zadacha68()
{
    // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    //Даны два неотрицательных числа m и n.
    Console.WriteLine("Введите неотрицательное число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите неотрицательное число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int result = Akkerman(m, n);
    Console.WriteLine($"Функция Аккермана = {result}");
}
Zadacha68();

int Akkerman(int n, int m)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}
