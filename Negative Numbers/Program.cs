using System;

namespace Negative_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size: ");
            int size = int.Parse(Console.ReadLine());
            
            int[] arr = new int[size];
            for(int i = 0;i < arr.Length;i++) {
                Console.WriteLine("Enter Element Number {0}: ", i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] negative = ExtractNegative(arr);

            if(negative.Length == 0) {
                Console.WriteLine("There is no negative elements");
            }else {
                Console.WriteLine("Negative elements: ");
                PrintElements(negative);
            }
        }

        public static void PrintElements(int[] arr) {
            foreach (var i in arr) {
                Console.WriteLine($"Element: {i}");
            }
        }

        public static byte CountN(int[] arr) {
            byte count = 0;
            foreach(var i in arr) {
                if (i < 0) {
                    count++;
                }
            }

            return count;
        }

        public static int[] ExtractNegative(int[] arr) {
            int[] negative = new int[CountN(arr)];
            byte idx = 0;
            
            foreach(var i in arr) {
                if (i < 0){
                    negative[idx] = i;
                    idx++;
                }
            }

            return negative;
        }
    }
}
