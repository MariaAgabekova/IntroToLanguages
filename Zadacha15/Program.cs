void Zadacha15()
{
    /*
    Напишите программу, которая принимает на вход цифру, обозначающую 
    день недели, и проверяет, является ли этот день выходным.
    6 -> да
    7 -> да
    1 -> нет
    */

    Console.WriteLine("Введите цифру, обозначающую день недели (от 1 до 7): ");
    int number = Convert.ToInt32(Console.ReadLine());

     if (number == 6 || number == 7 )
     {
        Console.WriteLine("Выходной день");
     }
     
     else
     {
        Console.WriteLine("Будний день");
     }

}
Zadacha15();

