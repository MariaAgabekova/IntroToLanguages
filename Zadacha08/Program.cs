void Zadacha08()
{
    /*
    Задача 8: Напишите программу, которая на вход принимает число (N > 0), 
    а на выходе показывает все чётные числа от 1 до N.
    5 -> 2, 4
    8 -> 2, 4, 6, 8
    */

    Console.WriteLine("Введите число: ");
    int N = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Чётные числа в промежутке от 1 до {N}: ");
 
    int i = 1;
       while (i < N)
       {
        Console.WriteLine(i+1);
        i = i + 2;
       }
     
}
Zadacha08();
