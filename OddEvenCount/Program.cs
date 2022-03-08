using System;

namespace OddEvenCount
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


            int[] even, odd;
            GetEvenOdd(arr, out even, out odd);
            PrintElements(even);
            PrintElements(odd, kind: "odd");

        }

        public static void PrintElements(int[] arr, string kind = "even") {
            Console.Write("the {0} elements are ", kind);
            foreach(var i in arr) {
                Console.Write(i + ", ");
            }
            Console.WriteLine("and the count is {0}", arr.Length);
        }

        public static int GetEvenCount(int[] arr) {
            int count = 0;
            foreach(var i in arr) {
                if (i % 2 == 0) {
                    count++;
                }
            }
            return count;
        }

        public static void GetEvenOdd(int[] arr, out int[] even, out int[] odd) {
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
