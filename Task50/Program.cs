// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matr = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
    Console.WriteLine();
}

int[,] matrix = CreateMatrixRndInt(5, 6, -10, 10);
PrintMatrix(matrix);

Console.WriteLine("Please enter the coordinates: ");
Console.Write("Row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Column: ");
int col = Convert.ToInt32(Console.ReadLine());

void MatrixIndexCheck(int[,] matr, int row_m, int col_m)
{
    if (row_m - 1 < matr.GetLength(0)
    && col_m - 1 < matr.GetLength(1))
    {
        Console.WriteLine(matr[row_m - 1, col_m - 1]);
    }
    else
    {
        Console.WriteLine("There is no such element in this matrix!");
    }
}

MatrixIndexCheck(matrix, row, col);