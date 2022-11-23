//Программа, которая выдает название дня недели по его номеру
Console.Clear();
Console.WriteLine("Введите введите номер дня недели ");
int num = int.Parse(Console.ReadLine());
if (num == 1) Console.WriteLine("Этот день - понедельник");
if (num == 2) Console.WriteLine("Этот день - вторник");
if (num == 3) Console.WriteLine("Этот день - среда");
if (num == 4) Console.WriteLine("Этот день - четверг");
if (num == 5) Console.WriteLine("Этот день - пятница");
if (num == 6) Console.WriteLine("Этот день - суббота");
if (num == 7) Console.WriteLine("Этот день - воскресение");
if (num < 1 || num > 7) Console.WriteLine("Введенное число не соответствует ни одному из дней недели");

