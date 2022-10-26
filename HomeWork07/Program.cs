// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dDoubleArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, columns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 1);
    return array;
}
void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
}
double[,] myArray = CreateRandom2dDoubleArray();
Show2dArray(myArray);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//           и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] Create2dRandomArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for( int i = 0; i < rows; i++)
        for( int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);
    return array;
}
void Show2dArray(int[,]array)
{
    for( int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}
void GetPositionElements(int[,]array)
{
    Console.Write("Input index rows of element: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input index columns of element: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    if(( rows >= 0 && rows < array.GetLength(0)) && (columns >= 0 && columns < array.GetLength(1)))
        Console.WriteLine($" Element with index [{rows},{columns}] = {array[rows,columns]}" );
    else
        Console.WriteLine(" Element not found. ");
}
int[,]myArray = Create2dRandomArray();
Show2dArray(myArray);
GetPositionElements(myArray);
*/
// Задача 52. Задайте двумерный массив из целых чисел.
//            Найдите среднее арифметическое элементов в каждом столбце.
int[,] Create2dRandomArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for( int i = 0; i < rows; i++)
        for( int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);
    return array;
}
void Show2dArray(int[,]array)
{
    for( int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}
double[]FindAverageInColumns(int[,]array)
{
    double[] newArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for( int i = 0; i < array.GetLength(0); i++)
            sum += array[i,j];
        newArray[j] = Math.Round((sum / array.GetLength(0)),1);
    }
    return newArray;
}
void ShowDoubleArray(double[]array)
{
    Console.Write("Average each columns:  ");
    for ( int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int[,]myArray = Create2dRandomArray();
Show2dArray(myArray);
double[]newArray = FindAverageInColumns(myArray);
ShowDoubleArray(newArray);