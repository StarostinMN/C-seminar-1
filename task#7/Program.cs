/* Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8 */
Console.Clear();
Console.Write("Введите трехзначное число ");
double N = Math.Abs(int.Parse(Console.ReadLine()));
double last_number = N % 10;
Console.Write("Последняя цифра введенного вами числа ");
Console.Write(last_number);