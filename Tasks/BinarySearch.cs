using System;

namespace Tasks
{
    public class BinarySearch
    {
        private static int[] array;
        public static void Processing()
        {
            Console.WriteLine("Binary Search Algorithm");
            array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * i;
            }
            Console.Write("Array to search number: ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Enter number to find");

            string inputValue = Console.ReadLine();

            if (int.TryParse(inputValue, out int inputNumber))
            {
                int index = BinSearchAlgr(inputNumber);
                if (index < 0)
                    Console.WriteLine("Element wasn't found");
                else
                    Console.WriteLine("Index of element: " + index);
            }
            Console.Read();
        }

        private static int BinSearchAlgr(int number)
        {
            int first = 0;
            int last = array.Length - 1;

            while (first <= last)
            {
                int mid = (first + last) / 2;
                int midVal = array[mid];

                if (midVal < number)
                    first = mid + 1;
                else if (midVal > number)
                    last = mid - 1;
                else
                    return mid;
            }
            return -1;
        }
    }
}