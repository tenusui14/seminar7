// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2

const int lines = 6;
const int columns = 6;

int Input(string message)
{
    Console.Write(message);
    string? value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[,] GetRandomMatrix(int lines, int columns)
{
    int[,] matrix = new int[lines, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 100);
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

bool CheckRange(int[,] matrix, int line, int column){
    if (line > matrix.GetLength(0) || column > matrix.GetLength(1)){
        Console.WriteLine("Такого элемента нет");
        return false;
    }
    else
    Console.WriteLine($"Элемент по указанным параметрам: {matrix[line,column]}");
    return true;
}


int[,] myMatrix = GetRandomMatrix(lines, columns);
PrintMatrix(myMatrix);
int line = Input("Введите номер сроки, начиная с 0: ");
int column = Input("Введите номер столбца, начиная с 0: ");
CheckRange(myMatrix, line, column);



