/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8
*/

int[,] InitMatrix(int m, int n)
{
    int[,]matrix = new int [m,n]
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = randomizer.NextDouble(new Random);
        }
    }
    return matrix;
}

void PrintMatrix(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write(${matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.WriteLine("Введите элемент №" + (i + 1));
    int[i] = int.Parse(Console.ReadLine());
}
 
SortByDescending2(matrix);
 
PrintMatrix(NewMatrix);
Console.ReadLine();

void PrintMatrix(int[] matrix)
{
    foreach (var item in matrix)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
 
void SortByDescending(int[] matrix)
    {
            matrix.Sort(matrix, (a, b) => b - a);
    }
 
void SortByDescending2(int[] matrix)
    {
        matrix.Sort(matrix);
        matrix.Reverse(matrix);
    }


