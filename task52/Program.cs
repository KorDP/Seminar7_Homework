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


void ColAvarage(int[,] matr)
{
    Console.Write("[");
    for (int i = 0; i < matr.GetLength(1); i++)
    {
    double result = 0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            result += matr[j,i];
        }
    if (i < matr.GetLength(1) -1 ) Console.Write(result / matr.GetLength(0) + ", ");
    else Console.Write(result / matr.GetLength(0) + "]");
    }
}


int[,] matrix = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(matrix);
Console.Write("Среднее арифметическое каждого столбца: ");
ColAvarage(matrix);