// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Input 5-digit number ");
string number = Console.ReadLine();
void Polyndrom (string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Number: {number} Polyndrom ");
    }
    else
    {
        Console.WriteLine($"Number: {number} not a Polyndrom");
    }
}
Polyndrom(number);
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance (double xa, double xb, double zA, double ya, double yb, double zB)
{
    return Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2) + Math.Pow((zB - zA),2));
}
Console.WriteLine("Input xa-coordinate ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input ya-coordinate ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input zA-coordinate ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input xb-coordinate ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input yb-coordinate ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input zB-coordinate ");
double zB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Distance(xa, xb, zA, ya, yb, zB));
*/
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void QubeNumbers(int n)
{
    int count = 1;
    while( count <= n)
    {
        Console.WriteLine(Math.Pow(count,3));
        count++;
    }
}
Console.WriteLine("Input N number ");
int n = Convert.ToInt32(Console.ReadLine());
QubeNumbers(n);
*/
