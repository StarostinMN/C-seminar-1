﻿/* Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка). */
Console.Clear();
Console.WriteLine("Введите целое число");
int num = Math.Abs(int.Parse(Console.ReadLine()));
if ((num%2 == 0))
{
    Console.WriteLine("Введенное число является четным");
}
else 
{
   Console.WriteLine("Введенное число не является четным"); 
}