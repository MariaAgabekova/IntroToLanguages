﻿void Zadacha19()
{
    //Задача 19. Напишите программу, которая принимает на вход 
    //пятизначное число и проверяет, является ли оно палиндромом.
    //14212 -> нет
    //23432 -> да
    //12821 -> да
    Console.WriteLine("Введите пятизначное число:");
    string number = Console.ReadLine();
    int length = number.Length;
    if (length == 5)
    {
        if (number[0] == number[4] && number[1] == number[3])
        {
            Console.WriteLine($"Число {number} является палиндромом.");
        }
        else
        {
            Console.WriteLine($"Число {number} не является палиндромом.");
        }
    }
    else
    {
        Console.WriteLine($"Ошибка. Число {number} не пятизначное.");
    }
}
Zadacha19();