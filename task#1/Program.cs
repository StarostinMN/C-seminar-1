//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.Clear();
Console.WriteLine("Введите первое число");
int sqr_num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число для проверки");
int num = int.Parse(Console.ReadLine());
if (Math.Pow(num, 2) == sqr_num)
{
    Console.Write($"Число {sqr_num} является квадратом числа {num}");
}
else
{
    Console.Write($"Число {sqr_num} не является квадратом числа {num}");
}
