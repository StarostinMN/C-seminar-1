﻿/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
Console.Clear();
int max = 0;
Console.Write("Введите первое число ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = int.Parse(Console.ReadLine());
max = num1;
if (num1 == num2)
{
    Console.Write("Введенные вами числа равны");
}
else
{
    if (num2 > max)
    {
        max = num2;
    }
    Console.WriteLine("Большее из введенных чисел равно ");
    Console.WriteLine(max);
}
