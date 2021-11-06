using System;

namespace ArrMethodsCs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {3, 7, 9, 2, 14, 6 };

            //Length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf()
            int index = Array.IndexOf(numbers, 9);
            //searches for index IndexOf(Source arr, value to look for index)
            Console.WriteLine("Index of 9: " + index);

            //Clear()
            Array.Clear(numbers, 0, 2);
            //Will set the range of elements to the default value Clear(Source arr, starting index, how many elements affected)
            foreach(int n in numbers)
            {
                Console.WriteLine(n);
            }

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            //will copy starting elements from source array to new array Copy(Source array, destination array, number of elements copied)
            Console.WriteLine("Effect of Copy()");
            foreach (int n in another)
            {
                Console.WriteLine(n);
            }

            //Sort();
            Array.Sort(numbers);
            //Sorts array from least to greatest Sort(Source arr)
            Console.WriteLine("Effect of Sort()");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            //Reverse()
            Array.Reverse(numbers);
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
