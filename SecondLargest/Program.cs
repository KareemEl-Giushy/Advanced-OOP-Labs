using System;

namespace SecondLargest
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

            Console.WriteLine("The Second Largest Number: " + bubbleSort(arr)[arr.Length - 2]);
        }

        public static int[] bubbleSort(int[] arr) {
            
            for(int i = 0;i< arr.Length - 1;i++) {
                for(int j = 0;j< arr.Length - i - 1;j++) {
                    if(arr[j] > arr[j+1]) {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }

            }
            return arr;
        }

    }
}
