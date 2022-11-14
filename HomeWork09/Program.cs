// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные
//            числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void SumOfDigits(int n)
{
    Console.Write(n + " ");
    if(n > 1) SumOfDigits(n - 1);
}
SumOfDigits(8);
*/
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//            натуральных элементов в промежутке от M до N.
/*
int SumOfDigits2(int m, int n)
{
    if(m > n) return m + SumOfDigits2(m - 1, n);
    if(n > m) return n + SumOfDigits2(m, n - 1);
    else return m;
}
int m = 4;
int n = 8;
Console.Write(SumOfDigits2(m,n));
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.     
//            Даны два неотрицательных числа m и n.
int FunctionAccerman(int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return FunctionAccerman(m - 1,1);
    if(m > 0 && n > 0) return FunctionAccerman(m - 1,FunctionAccerman(m,n - 1));
    return FunctionAccerman(m,n);
}
int m = 2;
int n = 3;
Console.Write(FunctionAccerman(m,n));