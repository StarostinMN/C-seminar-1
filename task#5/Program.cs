﻿/* Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2" */
Console.Clear();
Console.WriteLine("Введите ваше число ");
/* int N = Math.Abs(int.Parse(Console.ReadLine()));
int count = -N;
while (count <= N)
{
    Console.Write(count);
    Console.Write(" ");
    count++;
} */
int numA = Convert.ToInt32(Console.ReadLine());
int numB = -numA;
while (numB <= numA)
{
    Console.Write(numB);
    Console.Write(" ");
    numB += 1;
}