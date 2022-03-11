using System;

namespace RightDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Rows And Columns:");
            int rc = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rc,rc];

            Console.WriteLine("Enter Matrix Elements:");
            for(int i = 0;i < matrix.GetLength(0);i++)
                for(int j = 0;j < matrix.GetLength(1);j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());

            int rightDiagonal = 0;
            for(int i = 0;i < matrix.GetLength(0);i++)
                rightDiagonal += matrix[i,i];

            Console.WriteLine("Matrix: ");
            PrintMatrix(matrix);

            Console.WriteLine("The Addition Of Right Diagonal: " + rightDiagonal);
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
