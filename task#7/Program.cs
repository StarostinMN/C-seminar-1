/* Задача №7. Напишите программу, которая принимает на вход трёхзначное(работает с любыми числами) число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8 */
Console.Clear();
Console.Write("Введите целое число ");
int N = Math.Abs(int.Parse(Console.ReadLine()));
Console.Write("Последняя цифра введенного вами числа ");
Console.Write(N % 10);