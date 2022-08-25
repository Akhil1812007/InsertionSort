using System;

namespace InsertionSort
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            int[] input = { 3, 5, 1, 4, 9, 7, 21, 3, 7 };
            InsertionSort(input, input.Length);
            Console.WriteLine("the sorted array is");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
        public static void InsertionSort(int[] array, int size)
        {
            int key, j;
            for (int i = 1; i < size; i++)
            {
                key = array[i];
                j = i;
                
                while (j > 0 && array[j - 1] > key)
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = key;
                
            }
        }

    }
}
