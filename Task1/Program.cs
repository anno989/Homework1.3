// Напишите программу, которая принимает на вход 5-значное число и проверяет, является ли оно палиндромом (зеркальное число - 1-е число = последнему, 
// 2-е число = предпоследнему).Если решать данную задачу через строчки, то задача решится. Проверяете: если длина введенного числа равна 5, далее 
// вложенная проверка (если 1-е число равно последнему и 2-е равно предпоследнему), вывод - число является полиндромом, иначе число не является полиндромом).
// Нулевой индекс сравниваем с 4-м, 1-й - с 3-м. 
// Проверка на то, что введено именно 5-тизначное обязательна!
// Задачу можно решать через строчки, а можно математически (Как решать математически?)

////Вариант решения 1
// Console.WriteLine("Введите пятизначное число ");
// int number = int.Parse(Console.ReadLine()!);
// string NumberText = number.ToString(); 
// if (NumberText.Length == 5)
// {
//   if(NumberText[0] == NumberText[4] && NumberText[1] == NumberText[3])
//   {
//     Console.WriteLine($"Число {number} является палиндромом"); 
//   }
//   else
//   {
//       Console.WriteLine($"Число {number} не является палиндромом"); 
//   }
// }
// else
//   {
//     Console.WriteLine("Введенное число не является пятизначным!");
//   }

////Вариант решения 2
// Console.WriteLine("Введите число:  ");
// string? number = Console.ReadLine();
// bool task = true; 
// for (int i = 0; i < number.Length / 2; i++)
// {
//     if (number[i] != number[number.Length - i - 1])
//     {
//         task = false;
//         break;
//     }
// }
// if (task)
// {
//     Console.WriteLine("Палиндром");
// }
// else
// { 
// Console.WriteLine("Не палиндром");
// }


////Вариант решения 3
// Console.WriteLine("введите пятизначное число ");
// string? x = Console.ReadLine();
// char[] arr = x.ToCharArray();
// Array.Reverse(arr);
// string x2 = new String(arr);
// if(arr.Length == 5) 
// {
//     if (x == x2)
//         {
//             Console.WriteLine($"Введенное число {x} палиндром");
//         } 
//         else
//         {
//             Console.WriteLine($"Введенное число {x} не палиндром");
//         } 
// }
// else
// {
//     Console.WriteLine("Введено не 5-ти значное число");
// }


////Вариант решения 4
// Итерационная функция для проверки, является ли заданное число палиндромом или нет
Console.WriteLine("Введите пятизначное число ");
int number = int.Parse(Console.ReadLine()!);
if((int)Math.Log10(Math.Abs(number)) + 1 == 5) //Math Aps - проверка введенного числа по модулю; 
{
    int n = number;
    int rev = 0;
 
    while (n != 0)
    {
        int r = n % 10;
        rev = rev * 10 + r;
        n = n / 10;
    }
    if(number == rev)
    {
        Console.WriteLine($"Число {number} палиндром");
    }
    else
    {
        Console.WriteLine($"Число {number} не палиндром");
    }
}
else
{
    Console.WriteLine($"Число {number} не 5-значное");
}
  
    

