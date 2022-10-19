// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for ( int i = 0; i < size ; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int CountEvenNumber(int[] array)
{
    int count= 0;
    for (int i = 0; i < array.Length; i++)
    if ( array[i] % 2 == 0)
        count++;
    return count;
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the minimum number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the maximum number: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
int countEven = CountEvenNumber(myArray);
Console.Write($"{countEven}");
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for ( int i = 0; i < size ; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int SumOfNumbersOdd(int[]array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
        sum = sum + array[i];
    return sum;
}
Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the minimum number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the maximum number: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, min , max);
ShowArray(myArray);
int sumNum = SumOfNumbersOdd(myArray);
Console.WriteLine($"{sumNum}");
*/
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateArray(int size)
{
    double [] array = new double[size];
    for ( int i = 0; i < size ; i++)
    {
        Console.Write("Input array element : ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
double Difference(double[]array)
{
    double diff = 0;
    double min = array[0];
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
        if( array[i] > max)
            max = array[i];
        else if( array[i] < min)
            min = array[i];
        diff = max - min;
    Console.WriteLine($" The maximum element in array = {max}");
    Console.WriteLine($"The minimum element in array = {min}");
    return diff;
}
Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateArray(size);
ShowArray(myArray);
double differenceMinMax = Difference(myArray);
Console.WriteLine($"Difference between Max and min elements of array = {differenceMinMax}");
*/