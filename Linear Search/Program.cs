using System;

namespace Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            byte size = byte.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for(int i = 0;i < arr.Length;i++) {
                Console.WriteLine("Enter Element Number {0}:", i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("What Do you Search For");
            int item = int.Parse(Console.ReadLine());
            
            if(LinearSearch(arr, item))
                Console.WriteLine("Found !");
            else
                Console.WriteLine("Not Found :(");
        }

        public static bool LinearSearch(int[] arr, int item) {
            foreach (int i in arr) {
                if(i == item) {
                    return true;
                }
            }
            return false;
        }
    }
}
