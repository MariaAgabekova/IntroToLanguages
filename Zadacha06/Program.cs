﻿void Zadacha06()
{
    /*
    Задача 6: Напишите программу, которая на вход принимает число 
    и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    4 -> да
    -3 -> нет
    7 -> нет
    */

    Console.WriteLine("Введите число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());

     if (number1 % 2 == 0)
     {
        Console.WriteLine("Число чётное");
     }
     
     else
     {
        Console.WriteLine("Число нечётное");
     }

}
Zadacha06();