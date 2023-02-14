// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine());
int b = value / 10 % 10;
Console.WriteLine(b);