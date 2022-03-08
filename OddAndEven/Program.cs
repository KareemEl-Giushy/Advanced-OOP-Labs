using System;

namespace OddAndEven
{
    class Program
    {
        static int [] even, odd;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            byte size = byte.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for(int i = 0;i < arr.Length;i++) {
                Console.WriteLine("Enter Element Number {0}:", i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            GetEvenOdd(arr);
            Console.WriteLine("Even Numbers: ");
            PrintElements(even);
            Console.WriteLine("Odd Numbers: ");
            PrintElements(odd);
        }

        public static void PrintElements(int[] arr) {
            foreach (var i in arr) {
                Console.WriteLine($"Element: {i}");
            }
        }

        // I Don't Prefer This Methodology. O(n) / 
        // If We use Fixed Size from the User O(1)
        public static int GetEvenCount(int[] arr) {
            int count = 0;
            foreach(var i in arr) {
                if (i % 2 == 0) {
                    count++;
                }
            }
            return count;
        }

        public static void GetEvenOdd(int[] arr) {
            int count = GetEvenCount(arr);
            even = new int[count];
            odd = new int[arr.Length - count];

            int Eidx = 0;
            int Oidx = 0;
            for(int i = 0;i < arr.Length;i++) {
                if(arr[i] % 2 == 0) {
                    even[Eidx] = arr[i];
                    Eidx++;
                }else {
                    odd[Oidx] = arr[i];
                    Oidx++;
                }
            }
        }
    }
}
