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
            
            Tuple<bool, short> t = LinearSearch(arr, item);
            if(t.Item1 && t.Item2 != -1)
                Console.WriteLine("Found ! at index: " + t.Item2);
            else
                Console.WriteLine("Not Found :(");
        }

        public static Tuple<bool, short> LinearSearch(int[] arr, int item) {
            byte idx = 0;
            foreach (int i in arr) {
                if(i == item) {
                    return Tuple.Create<bool, short>(true, idx); // return indx if found
                }
                idx++;
            }
            return Tuple.Create<bool, short>(false, -1); // return -1 if not found
        }
    }
}
