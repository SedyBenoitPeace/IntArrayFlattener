using IntArrayFlattener.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IntArrayFlattener
{
    public class Flattener
    {
        public static void Main(string[] args)
        {
            var values = new[]
            {
                new[] { 1,2 },
                new[] { 3 },
                new[] { 4 }
            };
            var arrayFlattenedWithLinq = FlatWitLinq(values);
            var manuallyFlattenedArray = FlatArrayManually(values);
            Console.WriteLine("Array flattened with Linq" + "\n");
            Array.ForEach(arrayFlattenedWithLinq, Console.Write);
            Console.WriteLine("\n"+"Array flattened manually");
            Array.ForEach(manuallyFlattenedArray, Console.Write);
            Console.ReadLine();
        }

        private static int [] FlatWitLinq(int [][] arrayToFlat)
        {
            var arrayCheck = CheckArrayType(arrayToFlat);
            LaunchExceptionIfArrayWrong(arrayCheck);
            var result = arrayToFlat.SelectMany(value => value).Distinct();
            return result.ToArray();
        }

        private static int [] FlatArrayManually (int[][] arrayToFlat)
        {
            var arrayCheck = CheckArrayType(arrayToFlat);
            LaunchExceptionIfArrayWrong(arrayCheck);
            List<int> result = new List<int>(); // using list as we don't know the size of the array 
            HashSet<int> seenValues = new HashSet<int>(); // container for seen values when scanning the array
            for (int i = 0; i < arrayToFlat.Length; i++)
            {
                for (int j = 0; j < arrayToFlat[i].Length; j++)
                {
                    var value = arrayToFlat[i][j];
                    if (!seenValues.Contains(value))
                    {
                        result.Add(value);
                        seenValues.Add(value);
                    }
                }
            }
            return result.ToArray();
        }

        private static void LaunchExceptionIfArrayWrong(bool arrayCheck)
        {
            if (!arrayCheck) throw new Exception("Wrong array type");
        }

        private static bool CheckArrayType(int[][] arrayToFlat)
        {
            var isCorrectType = arrayToFlat.GetType().IsArrayOf<int>();
            return isCorrectType;
        }
    }
}
