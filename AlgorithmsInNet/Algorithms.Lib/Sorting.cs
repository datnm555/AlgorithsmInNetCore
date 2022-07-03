using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Lib
{
    public class Sorting
    {
        private static void BubleSort(int[] array)
        {
            for (int i = array.Length - 1; i < array.Length; i++)
            {
                for (int j = 0; j < i; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }

                }
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
            {
                return;
            }

            int temp = array[i];

            array[i] = array[j];

            array[j] = temp;
        }
    }
}
