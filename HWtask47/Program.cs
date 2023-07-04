﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

const int lines = 3;
const int columns = 4;

double[,] GetRandomMatrix(int lines, int columns)
{
    
    double[,] matrix = new double[lines, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            matrix[i, j] = Convert.ToDouble(Random.Shared.Next(-999,999)) / 10;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix){
       for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[,] myMatrix = GetRandomMatrix(lines, columns);
PrintMatrix(myMatrix);
