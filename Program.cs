int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] FillMatrix(int lengthI, int lengthJ)
{
    int[,] array = new int[lengthI, lengthJ];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

void SortMatrix(int[,] array2d)
{
    int[] sortArray = new int[array2d.GetLength(1)];
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            sortArray[j] = array2d[i, j];
        }
        Array.Sort(sortArray);
        Array.Reverse(sortArray);
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = sortArray[j];

        }
    }
}

void MinValueStr(int[,] array)
{
    int min = 0;
    int str = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (min == 0 || sum < min)
        {
            min = sum;
            str = i + 1;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов находится в строке {str}.");
}

int[,] ProductMatrix(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < resultArray.GetLength(0); i++)
        {
            for (int j = 0; j < resultArray.GetLength(1); j++)
            {
                int n = 0;
                int m = 0;
                for (int count = 0; count < resultArray.GetLength(1); count++)
                {
                    resultArray[i, j] += array1[i, m] * array2[n, j];
                    n++;
                    m++;
                }
            }
        }
    }
    else Console.WriteLine("Ошибка! Матрицу А можно умножить на матрицу В, только если число столбцов матрицы А равно числу строк матрицы В.");
    return resultArray;
}

Console.WriteLine("Задача 54");
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] matrix = FillMatrix(EnterNumber("Введите колличество строк: "), EnterNumber("Введите количество столбцов: "));
// PrintMatrix(matrix);
// Console.WriteLine();
// SortMatrix(matrix);
// PrintMatrix(matrix);
Console.WriteLine();

Console.WriteLine("Задача 56");
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] matrix2 = FillMatrix(EnterNumber("Введите колличество строк: "), EnterNumber("Введите количество столбцов: "));
// PrintMatrix(matrix2);
// MinValueStr(matrix2);
// Console.WriteLine();

Console.WriteLine("Задача 58");
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix3 = FillMatrix(EnterNumber("Введите колличество строк матрицы А: "), EnterNumber("Введите колличество столбцов матрицы А: "));
int[,] matrix4 = FillMatrix(EnterNumber("Введите колличество строк матрицы В: "), EnterNumber("Введите колличество столбцов матрицы В: "));
Console.WriteLine("Матрица 1:");
PrintMatrix(matrix3);
Console.WriteLine();
Console.WriteLine("Матрица 2:");
PrintMatrix(matrix4);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
PrintMatrix(ProductMatrix(matrix3, matrix4));

