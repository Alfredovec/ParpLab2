using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARP2
{
    class Program
    {
        private static Stopwatch _stopwatch;
        private static Random _random;

        static void Main(string[] args)
        {
            _stopwatch = new Stopwatch();
            _random = new Random();

            string command = string.Empty;
            while (command != "5")
            {
                Console.WriteLine("{0}1. Count positive numbers in array." +
                                  "{0}2. Bubble Sort{0}3. Polinom multiplying." +
                                  "{0}4. Array rounding{0}{0}", Environment.NewLine);
                command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        FirstTask();
                        break;
                    case "2":
                        SecondTask();
                        break;
                    case "3":
                        ThirdTask();
                        break;
                    case "4":
                        FourthTask();
                        break;
                }
                _stopwatch.Reset();
            }
        }

        static void FirstTask()
        {
            int[] array = new int[100000];
            for (int i = 0; i < array.Length; i++)
                array[i] = _random.Next(int.MinValue, int.MaxValue);
            
            _stopwatch.Start();
            int count = Functions.CountPositiveElements(array);
            _stopwatch.Stop();
            
            Console.WriteLine("Method 1.1: There are {0} positive numbers counted at {1} ticks",
                count, _stopwatch.ElapsedTicks);
            _stopwatch.Reset();

            _stopwatch.Start();
            count = Functions.CountPositiveElementsOptimized(array);
            _stopwatch.Stop();

            Console.WriteLine("Method 1.2 (Optimized): There are {0} positive numbers counted at {1} ticks",
                count, _stopwatch.ElapsedTicks);
        }

        static void SecondTask()
        {
            int[] array = new int[1000];
            for (int i = 0; i < array.Length; i++)
                array[i] = _random.Next(int.MinValue, int.MaxValue);

            _stopwatch.Start();
            int[] sortedFirst = Functions.BubbleSort(array);
            _stopwatch.Stop();

            Console.WriteLine("Method 2.1: There is bubble sort performed at {0} ticks",
               _stopwatch.ElapsedTicks);
            _stopwatch.Reset();

            _stopwatch.Start();
            int[] sortedSecond = Functions.BubbleSortOptimized(array);
            _stopwatch.Stop();

            Console.WriteLine("Method 2.2: There is bubble sort optimized performed at {0} ticks",
                _stopwatch.ElapsedTicks);
        }

        static void ThirdTask()
        {
            int[] arrayFirst = new int[1000];
            int[] arraySecond = new int[100];
            for (int i = 0; i < arrayFirst.Length; i++)
                arrayFirst[i] = _random.Next(-1000, 1000);
            for (int i = 0; i < arraySecond.Length; i++)
                arraySecond[i] = _random.Next(-1, 2);

            _stopwatch.Start();
            int[] multipliedFirst = Functions.PolinomMultiply(arrayFirst, arraySecond);
            _stopwatch.Stop();

            Console.WriteLine("Method 3.1: There is polinom multipluing performed at {0} ticks",
               _stopwatch.ElapsedTicks);
            _stopwatch.Reset();

            _stopwatch.Start();
            int[] multipliedSecond = Functions.PolinomMultiplyOptimized(arrayFirst, arraySecond);
            _stopwatch.Stop();

            Console.WriteLine("Method 3.2: There is optimized polinom multipluing performed at {0} ticks",
                _stopwatch.ElapsedTicks);
        }

        static void FourthTask()
        {
            float[] array = new float[1000];
            for (int i = 0; i < array.Length; i++)
                array[i] = (float) (_random.Next(100)*_random.NextDouble());

            _stopwatch.Start();
            float[] roundedFirst = Functions.ArrayRound(array);
            _stopwatch.Stop();

            Console.WriteLine("Method 2.1: There is array rounding performed at {0} ticks",
               _stopwatch.ElapsedTicks);
            _stopwatch.Reset();

            _stopwatch.Start();
            float[] roundedSecond = Functions.ArrayRoundOptimized(array);
            _stopwatch.Stop();

            Console.WriteLine("Method 2.2: There is optimized array rounding performed at {0} ticks",
                _stopwatch.ElapsedTicks);
        }
    }
}
