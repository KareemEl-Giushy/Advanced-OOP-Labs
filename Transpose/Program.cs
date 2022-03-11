using System;

namespace Transpose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rows: ");
            int r = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Columns: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[r, c];
            int[,] matrixTranspose = new int[r, c];

            Console.WriteLine("Enter Matrix Elements:");
            for(int i = 0;i < matrix.GetLength(0);i++)
                for(int j = 0;j < matrix.GetLength(1);j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());

            for(int i = 0;i < matrix.GetLength(0);i++)
                for(int j = 0;j < matrix.GetLength(1);j++)
                    matrixTranspose[j, i] = matrix[i, j];

            Console.WriteLine("Matrix: ");
            PrintMatrix(matrix);
            Console.WriteLine("Transpose: ");
            PrintMatrix(matrixTranspose);

        }

        static void PrintMatrix(int[,] m) {
            for(int i = 0;i < m.GetLength(0);i++){
                for(int j = 0;j < m.GetLength(1);j++)
                    Console.Write(m[i, j] + " ");
                
                Console.WriteLine();
            }
        }
    }
}
