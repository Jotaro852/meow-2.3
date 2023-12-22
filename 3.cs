using System;

class Program
{
    static void Main()
    {
        int n = 5; // Размер матрицы
        int[,] matrix = new int[n, n];
    
        // Заполнение первой строки и первого столбца значениями 1
        for (int i = 0; i < n; i++)
        {
            matrix[0, i] = 1;
            matrix[i, 0] = 1;
        }
        
        // Заполнение остальных ячеек матрицы
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
            }
        }
        
        // Вывод матрицы
        Console.WriteLine("Полученная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
} 
