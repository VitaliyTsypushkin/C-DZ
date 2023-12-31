﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],3} ");
        }
        Console.WriteLine();
    }
}

double[] Average(int[,] matr)
{
    double[] averageMatr = new double[matr.GetLength(1)];

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double averageNum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            averageNum += (matr[i, j]);
        }
        averageMatr[j] = Math.Round(averageNum / matr.GetLength(0), 2);
    }
    return averageMatr;
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine(string.Join("  ", Average(matrix)));
