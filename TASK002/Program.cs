// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
//
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//Console.WriteLine("Введите число: ");
//int number = int.Parse(Console.ReadLine());
//int thirdnumber = number % 10;
//Console.WriteLine(b);

int thirdnumber(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (thirdnumber(number) == -1)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine("Третья цифра: ", thirdnumber(number));