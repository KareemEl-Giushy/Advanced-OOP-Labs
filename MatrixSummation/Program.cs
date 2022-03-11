using System;

namespace MatrixSummation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4,3];

            Console.WriteLine("Enter A 4x3 Matrix");
            ReadMatrix(ref matrix);

            int[] arrRow = ArrayRow(matrix);
            int[] arrCol = ArrayCol(matrix);

            (float rowAvg, int rowMax) = GetAvgMax(arrRow);
            (float colAvg, int colMax) = GetAvgMax(arrCol);

            Console.WriteLine("Matrix: ");
            PrintMatrix(matrix);

            Console.WriteLine("Summation Of Rows: ");
            PrintArray(arrRow);

            Console.WriteLine("Summation Of Columns: ");
            PrintArray(arrCol);

            Console.WriteLine("The Avarage Of Array Rows {0} And The Max Value Is {1}", rowAvg, rowMax);
            Console.WriteLine("The Avarage Of Array Columns {0} And The Max Value Is {1}", colAvg, colMax);
            
        }
        static void ReadMatrix(ref int[,] matrix) {
            for(int i = 0;i < matrix.GetLength(0);i++) {
                Console.WriteLine("Enter New Row:");
                for(int j = 0;j < matrix.GetLength(1);j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        static void PrintMatrix(int[,] m) {
            for(int i = 0;i < m.GetLength(0);i++){
                for(int j = 0;j < m.GetLength(1);j++)
                    Console.Write(m[i, j] + " ");
                
                Console.WriteLine();
            }
        }

        static void PrintArray(int[] arr) {
            foreach(var i in arr) {
                Console.WriteLine("Element: " + i);
            }
        }
        static int[] ArrayRow(int[,] matrix) {

            int[] summation = new int[4];

            for(int i = 0;i < matrix.GetLength(0);i++) {
                for(int j = 0;j < matrix.GetLength(1);j++)
                    summation[i] += matrix[i, j];
            }

            return summation;
        }
        static int[] ArrayCol(int[,] matrix) {
            int[] summation = new int[3];

            for(int i = 0;i < matrix.GetLength(1);i++) {
                for(int j = 0;j < matrix.GetLength(0);j++){
                    summation[i] += matrix[j, i];
                }
            }

            return summation;
        }

        static Tuple<float, int> GetAvgMax(int[] arr) {
            int sum = 0;
            int max = arr[0];
            foreach(var i in arr){
                if(max < i) {
                    max = i;
                }
                sum += i;
            }

            float avg = sum / arr.Length;

            return Tuple.Create<float, int>(avg, max);
        }
    }
}
