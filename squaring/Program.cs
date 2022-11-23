// Напишите программу, которая на вход принимает число и выводит его квадрат

Console.Clear();

Console.WriteLine("Введите число: ");

string input = Console.ReadLine();

if (input == ""){
    Console.Write("Ничего не было введено!");
}
else
{int num = int.Parse(input);

int sqr = num * num;

Console.Write("Квадрат числа " + num + " = " + sqr);}





