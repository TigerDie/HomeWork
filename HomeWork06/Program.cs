// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//            сколько чисел больше 0 ввёл пользователь.
/*
int HowMuchNumbersMoreZero(int amountNumMoreZero)
{
    int amount = 0;
    int count = 0;
    do
    {
        Console.Write("Input a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) 
        {
            count++;
            amount++;
        }
    }   while (amount < amountNumMoreZero);
    return count;
}

Console.Write("enter how many numbers you want to enter? : ");
int amountNumMoreZero = Convert.ToInt32(Console.ReadLine());
int result = HowMuchNumbersMoreZero(amountNumMoreZero);
Console.WriteLine($"amount numbers more zero = {result}");
Console.ReadLine();
*/
// Задача 43: Напишите программу, которая найдёт точку пересечения 
//            двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 *
//            x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//            b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double[] array = new double[2];
    array[0] = (b2 - b1) / (k1 - k2);
    array[1] = k1 * array[0] + b1;
    return array;
}

void PrintIntersection(double[] array)
{
    Console.Write($"IntersectionPoint = [{array[0]}; {array[1]}].");
}

Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
if(k1 == k2) Console.WriteLine("no point of intersection.");
else
{
    double[] result = IntersectionPoint(b1,k1,b2,k2);
    PrintIntersection(result);
}
Console.ReadLine();