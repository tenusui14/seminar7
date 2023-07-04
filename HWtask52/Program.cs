// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

const int Rows = 4;
const int Columns = 5;

int[,] GetRandomMatrix(int lines, int columns)
{
    int[,] matrix = new int[lines, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }

    }

    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void AverageColumns(int[,] matrix){
double avg = 0;
for(int i = 0; i < matrix.GetLength(1); i++){
for(int j = 0; j < matrix.GetLength(0); j++){
    avg = (avg + matrix[j,i]);
}
avg /= Rows;
Console.WriteLine($"Среднее арифмитическое {i+1} столбца = {avg}");
}
}

int[,] myMatrix = GetRandomMatrix(Rows,Columns);
PrintMatrix(myMatrix);
AverageColumns(myMatrix);

