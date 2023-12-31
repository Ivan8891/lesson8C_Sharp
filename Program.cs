﻿int EnterNumber(string message)
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

int[,,] FillMatrix3d(int lengthI, int lengthJ, int lengthY)
{
    int[,,] array = new int[lengthI, lengthJ, lengthY];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int y = 0; y < array.GetLength(2); y++)
            {
                array[i, j, y] = new Random().Next(10, 100);
            }
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

void PrintMatrix3d(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int y = 0; y < array.GetLength(2); y++)
            {
                Console.Write($"{array[i, j, y]} ({i}, {j}, {y}) ");
            }
            Console.WriteLine();
        }
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
                for (int n = 0; n < resultArray.GetLength(1); n++)
                {
                    resultArray[i, j] += array1[i, n] * array2[n, j];
                }
            }
        }
    }
    else Console.WriteLine("Ошибка! Матрицу А можно умножить на матрицу В, только если число столбцов матрицы А равно числу строк матрицы В.");
    return resultArray;
}

int[,] FillSpiral(int n, int m)
{
    int[,] array = new int[n, m];
    int count = 1;
    int i = 0;
    int j = 0;
    bool stop = true;
    array[i, j] = count;
    while (count < array.GetLength(0) * array.GetLength(1))
    {
        while (stop)
        {
            if (j + 1 < array.GetLength(1))
            {
                if (array[i, j + 1] == 0)
                {
                    j++;
                    count++;
                    array[i, j] = count;
                }
                else stop = false;
            }
            else stop = false;
        }
        stop = true;
        while (stop)
        {
            if (i + 1 < array.GetLength(0))
            {
                if (array[i + 1, j] == 0)
                {
                    i++;
                    count++;
                    array[i, j] = count;
                }
                else stop = false;
            }
            else stop = false;
        }
        stop = true;
        while (stop)
        {
            if (j > 0)
            {
                if (array[i, j - 1] == 0)
                {
                    j--;
                    count++;
                    array[i, j] = count;
                }
                else stop = false;
            }
            else stop = false;
        }
        stop = true;
        while (stop)
        {
            if (i > 0)
            {
                if (array[i - 1, j] == 0)
                {
                    i--;
                    count++;
                    array[i, j] = count;
                }
                else stop = false;
            }
            else stop = false;
        }
        stop = true;
    }
    return array;
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

int[,] matrix = FillMatrix(EnterNumber("Введите колличество строк: "), EnterNumber("Введите количество столбцов: "));
PrintMatrix(matrix);
Console.WriteLine();
SortMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

Console.WriteLine("Задача 56");
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix2 = FillMatrix(EnterNumber("Введите колличество строк: "), EnterNumber("Введите количество столбцов: "));
PrintMatrix(matrix2);
MinValueStr(matrix2);
Console.WriteLine();

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
Console.WriteLine();

Console.WriteLine("Задача 60");
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

PrintMatrix3d(FillMatrix3d(EnterNumber("Введите колличество строк: "), EnterNumber("Введите количество столбцов: "), EnterNumber("Введите глубину массива: ")));
Console.WriteLine();

Console.WriteLine("Задача 62");
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix5 = FillSpiral(EnterNumber("Введите колличество строк: "), EnterNumber("Введите количество столбцов: "));
PrintMatrix(matrix5);
