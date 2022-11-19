void Zadacha10()
{
    /*
    Задача 10: Напишите программу, которая принимает на вход 
    трёхзначное число и на выходе показывает вторую цифру этого числа.
   456 -> 5
   782 -> 8
   918 -> 1
    */

Console.WriteLine("Введите трёхзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    if(number / 100 > 0 & number / 100 < 10 || number > -1000 & number < -99)
    {
    int hundreds = number / 100;
    int result = (number - hundreds * 100) / 10;
       if(result < 0)
       {
         result = result * (-1);
       }
    Console.WriteLine($"Вторая цифра трехзначного числа равна {result}");
    }

    else
    {
     Console.WriteLine($"{number} не является трехзначным числом");
    }

   
}
Zadacha10();