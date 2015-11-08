using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARP2
{
    public class Functions
    {
        public static int CountPositiveElements(int[] array)
        {
            int result = 0;
            foreach (int element in array)
            {
                if (element > 0)
                    result++;
            }
            return result;
        }

        public static int CountPositiveElementsOptimized(int[] array)
        {
            int result = 0;
            foreach (int element in array)
            {   
                result += -~(element >> 31);
            }
            return result;
        }

        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = 0; j < array.Length - i - 1; j++)
                    if (array[j + 1] < array[j])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
            return array;
        }

        public static int[] BubbleSortOptimized(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = i; j >= 0; j--)
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
            return array;
        }


        public static int[] PolinomMultiply(int[] first, int[] second)
        {
            int[] result = new int[first.Length + second.Length - 1];
            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    result[i + j] += first[i]*second[j];
                }
            }
            return result;
        }

        public static int[] PolinomMultiplyOptimized(int[] first, int[] second)
        {
            int[] result = new int[first.Length + second.Length - 1];
            for (int j = 0; j < second.Length; j++)
            {
                if (second[j] != 0)
                    continue;
                
                var positive = second[j].Equals(1);

                for (int i = 0; i < first.Length; i++)
                    result[i + j] += positive ? first[i] : -first[i];
            }
            return result;
        }

        public static float[] ArrayRound(float[] array)
        {
            float[] result = new float[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    result[i] = (float)(int)(array[i] + 0.5);
                }
                else
                {
                    result[i] = (float)(int)(array[i] - 0.5);
                }
            }
            return result;
        }

        public static float[] ArrayRoundOptimized(float[] array)
        {
            float[] result = new float[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = ((int)(array[i] * ((int)array[i]) + 1)) / ((int)array[i]);
            }
            return result;
        }
    }
}
