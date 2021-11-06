﻿using System;

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
            Console.WriteLine("Index of 9: " + index);
        }
    }
}
