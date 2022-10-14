// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
double APowB(double a, double b)
{
    return Math.Pow (a,b);   
}
Console.WriteLine("Input first digit");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second digit");
double b = Convert.ToInt32(Console.ReadLine());
double c = APowB(a,b);

Console.WriteLine($"Number in POW is {c} ");
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumNumber(int number)
  {
    int count = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
   return result;
  }

Console.Write("Input number : ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(number);
Console.WriteLine($"Sum of digits: {sumNumber} ");
// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] CreateRandomArray(int size , int minValue , int maxValue)
{
    int[] newArray = new int[size];
    
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 1;
int max = 99;
int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
*/