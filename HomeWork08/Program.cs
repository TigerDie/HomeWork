// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
//            по убыванию элементы каждой строки двумерного массива.
int[,] Create2DArrayRandom(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return array;
}

void Print2DArray(int[,]array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
            if(j < array.GetLength(1)-1)
                Console.Write(", ");
        }
        if(i < array.GetLength(0)-1)
            Console.WriteLine(",");
        else Console.WriteLine(".");
    }
    Console.WriteLine();
}
/*
int[,] ReverseToMin(int[,]array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i,k] > array[i,j])
                {
                    int temp = array[i,k];
                    array[i,k] = array[i,j];
                    array[i,j] = temp;
                }
            }
        }
    }
    return array;
}
*/
int[,] myArray = Create2DArrayRandom(4,4,1,9);
Print2DArray(myArray);
/*
ReverseToMin(myArray);
Print2DArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//            которая будет находить строку с наименьшей суммой элементов.
/*
int[] MinSumElementsOfRows(int[,]array)
{
    int[]sumRows = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
            sumRows[i] = sum;
        }
    }
    return sumRows;
}

void PrintSumRows(int[]array)
{
    Console.Write("Sum of elements in rows: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length -1)
            Console.Write(", ");
    }
    Console.WriteLine();
}

int IndexMinElements(int[]array)
{
    int iMin = 0;
    int min = array[iMin];
    for(int i = 0; i < array.Length - 1; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
            iMin = i;
        }
    }
    return iMin;
}

int[] sumRows = MinSumElementsOfRows(myArray);
PrintSumRows(sumRows);
int numberRow = (IndexMinElements(sumRows) + 1);
Console.WriteLine($"Number of Row with minimal sum: {numberRow}");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
//            произведение двух матриц.
/*
int[,] MatrixMultiplication(int[,]array0 , int[,]array1)
{
    var newArray = new int[array0.GetLength(0), array1.GetLength(1)];
    if (array0.GetLength(0) != array1.GetLength(1))
    {
        Console.WriteLine("Multiplication of matrix is impossible.");
        Console.WriteLine("amount rows first matrix must be equals amount columns second matrix.");
        return null;
    }
    else
    {
        for(int i = 0; i < array0.GetLength(0); i++)
        {
            for(int j = 0; j < array1.GetLength(1); j++)
            {
                newArray[i,j] = 0;
                for(int k = 0; k < array1.GetLength(1); k++)
                {
                    newArray[i,j] += array0[i,k] * array1[k,j];
                }
            }
        }
    }
    return newArray;
}

int[,]array0 = Create2DArrayRandom(2,2,2,4);
Print2DArray(array0);
int[,]array1 = Create2DArrayRandom(2,2,2,4);
Print2DArray(array1);
int[,]resultArray = MatrixMultiplication(array0,array1);
if(resultArray != null)
    Print2DArray(resultArray);
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//            Напишите программу, которая будет построчно выводить массив, добавляя
//            индексы каждого элемента.
/*
int[] TwoPositiveDigitArray()
{
    int[]array = Enumerable.Range(10, 99).ToArray();
    for(int i = 0; i < array.Length; i++)
    {
        int j = new Random().Next(0, 99);
        if(j != i)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    return array;
}

int[,,]Create3DArray(int[]array, int height, int width, int depth)
{
    int m = 0;
    int[,,]array3D = new int [height, width, depth];
    for(int i = 0; i < height; i++)
    {
        for(int j = 0; j < width; j++)
        {
            for(int k = 0; k < depth; k++)
            {
                array3D[i,j,k] = array[m];
                m++;
            }
        }
    }
    return array3D;
}

void Print3DArray(int[,,]array)
{
    Console.WriteLine("\nElements with index (i,j,k) in three dimensional array: ");
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i,j,k] + " ");
                Console.Write($"({i},{j},{k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
try
{
    Console.Write("Input a height(numbers of rows): ");
    int height = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a width(numbers of columns): ");
    int width = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a depth array:");
    int depth = Convert.ToInt32(Console.ReadLine());

    int[]array = TwoPositiveDigitArray();
    int[,,]array3D = Create3DArray(array, height, width, depth);
    Print3DArray(array3D);
}
catch
{
    Console.WriteLine("\nInvalid input!");
    Console.WriteLine("Input digits bigger then 0 or decrease size array. ");
}
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,]SpiralFilling(int rows, int columns)
{
    int[,]arraySpiral= new int[rows, columns];
    for(int walk = 0, valueElements = 1; valueElements <= rows* columns; walk++)
    {
        for(int i = walk, j = walk; j < columns - walk; j++)
        {
            arraySpiral[i,j] = valueElements;
            valueElements++;
        }
        if(valueElements > rows * columns) break;
        for(int i = walk + 1, j = columns - walk - 1; i < rows - walk; i++)
        {
            arraySpiral[i,j] = valueElements;
            valueElements++;
        }
        if(valueElements > rows * columns) break;
        for(int i = rows - walk - 1, j = columns - walk - 2; j >= walk; j--)
        {
            arraySpiral[i,j] = valueElements;
            valueElements++;
        }
        if(valueElements > rows * columns) break;
        for(int i = rows - walk - 2, j = walk; i > walk; i--)
        {
            arraySpiral[i,j] = valueElements;
            valueElements++;
        }
    }
    return arraySpiral;
}

void PrintArraySpiral(int[,] array, int fillZero = 2)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j].ToString($"D{fillZero}") + " ");
        }
        Console.WriteLine();
    }
}
try
{
    Console.Write("Input a numbet of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,]arraySpiral = SpiralFilling(rows, columns);
    PrintArraySpiral(arraySpiral);
}
catch
{
    Console.WriteLine("\nInvalid input. Input number bigger then 0 .");
}