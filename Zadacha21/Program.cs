void Zadacha21()
{
    //Задача 21. Напишите программу, которая принимает 
    //на вход координаты двух точек и находит расстояние
    //между ними в 3D пространстве.
    //A(3, 6, 8); B(2, 1, -7), -> 15.84
    //A(7, -5, 0); B(1, -1, 9)-> 11.53
    Console.Write("Для точки A введите координату x1 = ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Для точки A введите координату y1 = ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Для точки A введите координату z1 = ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Для точки B введите координату x2 = ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Для точки B введите координату y2 = ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Для точки B введите координату z2 = ");
    int z2 = Convert.ToInt32(Console.ReadLine());
    int C = x2 - x1;
    int D = y2 - y1;
    int E = z1 - z2;
    double length = Math.Sqrt(C * C + D * D + E * E);
    length = Math.Round(length, 2);
    Console.WriteLine($"Расстояние между точками A и B равно {length}");
}
Zadacha21();