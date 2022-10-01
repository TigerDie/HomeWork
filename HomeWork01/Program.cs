// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*

Console.Write("Input First number ");
int n1= Convert.ToInt32 (Console.ReadLine());
Console.Write("Input Second number ");
int n2= Convert.ToInt32 (Console.ReadLine());
if (n1 < n2 )
{
    Console.WriteLine($" number {n1} Minimum, number {n2} Maximum");
}

*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


/*

Console.Write("Input First number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Second number ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Third number ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > a)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine($"Max Number {max} ");

*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*

Console.Write("Input a number ");
int a = Convert.ToInt32(Console.ReadLine());
int degree = a / 2;
if (a % 2 == 0)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}

*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*

Console.Write("Input a number ");
int a =Convert.ToInt32(Console.ReadLine());
int current;
if (a > 0)
{
    current = a % 3;
}
else
{
    current = a % 2;
}
while (current <= a)
{
    Console.Write(current + " ");
    current = current + 2 ;
}

*/