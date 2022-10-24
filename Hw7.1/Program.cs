// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();
System.Console.WriteLine();

int[,] GetTable(int row, int col, int min, int max)
{
    int[,] table = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            table[i, j] = new Random().Next(min, max + 1);
        }
    }
    return table;
}

void PrintTable(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            System.Console.Write(tab[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int row = new Random().Next(3, 4);
int col = new Random().Next(3, 4);
int min = -10;
int max = 10;

int[,] matrix = GetTable(row, col, min, max);
PrintTable(matrix);
