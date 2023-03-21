﻿namespace Jarai.CSharp.Linq.YieldReturn
{
    internal class DataGenerator
    {
        /// <summary>
        ///     Calculates a result List of values in advance and returns it
        /// </summary>
        public IEnumerable<int> GenerateData(int count)
        {

            var result = new List<int>();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Calculating value {i}");

                Thread.Sleep(10); // simulate slow calculation...
                result.Add(i);
            }

            return result;
        }

        /// <summary>
        ///     ON DEMAND yields one element of the result
        ///     (Only used values are calculated)
        /// </summary>
        public IEnumerable<int> GenerateDataUsingYieldReturn(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Yielding value {i}");

                Thread.Sleep(10); // simulate slow calculation...

                yield return i;
            }
        }
    }
}
