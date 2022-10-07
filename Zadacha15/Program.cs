/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число от 1 до 7:");
string DayOfWeek = Console.ReadLine();

if (DayOfWeek == "1")
Console.WriteLine("Понедельник");

else if (DayOfWeek == "2")
Console.WriteLine("Вториник");

else if (DayOfWeek == "3")
Console.WriteLine("Среда");

else if (DayOfWeek == "4")
Console.WriteLine("Четверг");

else if (DayOfWeek == "5")
Console.WriteLine("Пятница");

else if (DayOfWeek == "6")
Console.WriteLine("Суббота, является выходным днем");

else if (DayOfWeek == "7")
Console.WriteLine("Воскресенье, является выходным днем");