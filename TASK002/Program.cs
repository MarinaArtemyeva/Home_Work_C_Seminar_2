// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
//
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine());
int b = value % 10;
Console.WriteLine(b);