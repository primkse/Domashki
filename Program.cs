﻿Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32 (Console.ReadLine());
if(num1 > num2)
{
    Console.WriteLine($"{num1} больше {num2}");
}
else if(num1 < num2)
{
    Console.WriteLine($"{num2} больше {num1}");
}
else
{
    Console.WriteLine("Числа равны");
}