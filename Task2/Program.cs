//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние ними в 3D пространстве.
Console.WriteLine("Введите координату X точки1: ");
int xa = int.Parse(Console.ReadLine()!); 
Console.WriteLine("Введите координату Y точки1: ");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z точки1: ");
int za = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату X точки2: ");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки2: ");
int yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z точки2: ");
int zb = int.Parse(Console.ReadLine()!);
double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)); //корень из суммы разности координат в квадрате 
Console.Write($"Расстояние между точками: {result:f2}");