//Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine()!);
for(int i = 1; i <= n; i++) //"int i = 1" - счетчик (точка начала), "i <= n" - условие прохождения, "i++" - шаг) Например, шаг "2" это i+=2
{
    Console.Write($"{Math.Pow(i, 3)} "); 
}
