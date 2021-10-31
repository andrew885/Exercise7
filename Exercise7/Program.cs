using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 8, -9, 0, 6, 7 };
            Console.Write("Original array: ");
            ShowArray(numbers);

            IEnumerable<int> sortedNumbers = numbers.OrderByDescending(s => s);
            Console.Write("Sorted array: ");
            ShowArray(sortedNumbers.ToArray());

            int[,] doubleDimArray = new int[,] { { 18,6,9}, {-8,9,15} };
            Console.Write("Two dimensional array: ");
            ShowArray(doubleDimArray);
            Console.Write("Max elements in Two dimensional array: ");
            ShowMax(doubleDimArray);
        }

        static public void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.Write(array[array.Length - 1] + "");
            Console.WriteLine();
        }
        static public void ShowArray(int[,] doubleArray)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("{");
                for (int i = 0; i < doubleArray.Length / 2-1; i++)
                {
                    Console.Write(doubleArray[j, i] + ", ");
                }
                Console.Write(doubleArray[j,doubleArray.Length/2 - 1] + "");
                Console.Write("}");            
            }
            Console.WriteLine();
        }
        static public void ShowMax(int[,] doubleArray)
        {            
            for (int j = 0; j < 2; j++)
            {
                int max = int.MinValue;
                Console.Write("{");
                for (int i=0; i < doubleArray.Length / 2; i++)
                {
                    if (doubleArray[j, i] > max)
                        max = doubleArray[j,i];                    
                }
                Console.Write(max);
                Console.Write("}");
            }
            Console.WriteLine();
        }
    }  

}
