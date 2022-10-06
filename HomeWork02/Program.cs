// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int SecondNumberOfDigit (int num)
{
    int a = num % 100;
    int sum = a /10 ;
    return sum;
}
Console.WriteLine("Input a number ");
int number = Convert.ToInt32(Console.ReadLine());
int secondNumber = SecondNumberOfDigit(number);
Console.WriteLine($" Second Number {secondNumber} of Digit {number} ");
*/
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.WriteLine("Input a number ");
int a = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(a);
if (number.Length > 2)
{
    Console.WriteLine($"Third number {number[2]}");
}
else
{
    Console.WriteLine("there is no third digit ");
}
 */
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool NumberDayOfWeeks(int a)
{
    bool result;
    if (a >= 6)
    {
        result = true;
    }
    else
    {
        result = false;
    }
    if (a > 7)
    {
        result = false;
    }
    return result;
}
Console.Write("Input a number ");
int a = Convert.ToInt32(Console.ReadLine());
bool res = NumberDayOfWeeks(a);
Console.WriteLine(res);
*/