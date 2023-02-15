// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите номер дня недели: ");
int numberday = int.Parse(Console.ReadLine());
if(numberday >= 1 && numberday <= 5)
{
    Console.WriteLine("Нет, это не выходной день");
}
else if (numberday >= 6 && numberday <= 7)
{
    Console.WriteLine("Да, этот день выходной");
}
else Console.WriteLine("Такого дня недели не существует");