/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (number < 999 && number > 99)
{
    number = number / 10;
    Console.WriteLine($"Вторая цифра числа {number = number % 10}");
}
else
Console.WriteLine("Введенно не трехзначное число");
