using System;
using System.Linq;

namespace Homework_08
{
    class Program
    {
        /// <summary>
        /// Метод сортировки подсчетом.
        /// </summary>
        static void CountingSort(int[] arr)
        {
            int[] freqArr = new int[arr.Max() + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                freqArr[arr[i]]++;
            }
            int x = 0;
            for (int k = 0; k < freqArr.Length; k++)
            {
                for (int j = 0; j < freqArr[k]; j++)
                {
                    arr[x++] = k;
                }
            }
        }

        /// <summary>
        /// Метод сортировки Хоара
        /// </summary>
        static void Quicksort(int[] arr, int start, int end, ref int counter)
        {
            int middle = arr[(end - start) / 2 + start];
            int temp;
            int S = start;
            int E = end;
            while (S <= E)
            {
                while (arr[S] < middle && S <= end)
                {
                    S++;
                }
                while (arr[E] > middle && E >= start)
                {
                    E--;
                }
                counter++;
                if (S <= E)
                {
                    temp = arr[S];
                    arr[S] = arr[E];
                    arr[E] = temp;
                    S++;
                    E--;
                }
            }
            if (E > start) Quicksort(arr, start, E, ref counter);
            if (S < end) Quicksort(arr, S, end, ref counter);
        }

        /// <summary>
        /// Метод сортировки слиянием
        /// </summary>
        static int[] MergeSort(int[] arr, ref int counter)
        {
            if (arr.Length == 1)
            {
                return arr;
            }
            int middle = arr.Length / 2;
            return Merge(MergeSort(arr.Take(middle).ToArray(), ref counter), MergeSort(arr.Skip(middle).ToArray(), ref counter), ref counter);
        }

        /// <summary>
        /// Метод слияния подмассивов
        /// </summary>
        static int[] Merge(int[] arr1, int[] arr2, ref int counter)
        {
            int ptr1 = 0, ptr2 = 0;
            int[] merged = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < merged.Length; i++)
            {
                counter++;
                if (ptr1 < arr1.Length && ptr2 < arr2.Length)
                {
                    merged[i] = arr1[ptr1] > arr2[ptr2] ? arr2[ptr2++] : arr1[ptr1++];
                }
                else
                {
                    merged[i] = ptr2 < arr2.Length ? arr2[ptr2++] : arr1[ptr1++];
                }
            }
            return merged;
        }

        static int AddTwoPyramid(int[] arr, int i, int N, ref int counter)
        {
            int imax;
            int buf;
            if ((2 * i + 2) < N)
            {
                counter++;
                if (arr[2 * i + 1] < arr[2 * i + 2]) imax = 2 * i + 2;
                else imax = 2 * i + 1;
            }
            else imax = 2 * i + 1;
            if (imax >= N)
            {
                counter++;
                return i;
            }
            if (arr[i] < arr[imax])
            {
                counter++;
                buf = arr[i];
                arr[i] = arr[imax];
                arr[imax] = buf;
                if (imax < N / 2) i = imax;
            }
            return i;
        }

        static void PyramidSort(int[] arr, ref int counter)
        {
            //step 1: building the pyramid
            for (int i = arr.Length / 2 - 1; i >= 0; --i)
            {
                long prev_i = i;
                i = AddTwoPyramid(arr, i, arr.Length, ref counter);
                if (prev_i != i) ++i;
            }

            //step 2: sorting
            int buf;
            for (int k = arr.Length - 1; k > 0; --k)
            {
                buf = arr[0];
                arr[0] = arr[k];
                arr[k] = buf;
                int i = 0, prev_i = -1;
                while (i != prev_i)
                {
                    prev_i = i;
                    i = AddTwoPyramid(arr, i, k, ref counter);
                }
            }
        }

        static void ShellSort(int[] vector, ref int counter)
        {
            int step = vector.Length / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < vector.Length; i++)
                {
                    int value = vector[i];
                    for (j = i - step; (j >= 0) && (vector[j] > value); j -= step)
                    {
                        vector[j + step] = vector[j];
                        counter++;
                    }
                    vector[j + step] = value;
                }
                step /= 2;
            }
        }

        /// <summary>
        /// Метод заполняет массив случайными числами от 0 до max
        /// </summary>
        static void RndArrValue(int[] array, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(max);
            }
        }

        /// <summary>
        /// Метод выводит массив в консоль
        /// </summary>
        static void PrintArr(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] referenceArray = new int[100000];
            RndArrValue(referenceArray, 100);
            //PrintArr(referenceArray);
            int counter = 0;

            int[] arr1 = new int[referenceArray.Length];
            Array.Copy(referenceArray, arr1, referenceArray.Length);
            DateTime t1 = DateTime.Now;
            CountingSort(arr1);
            Console.WriteLine(DateTime.Now - t1);
            //PrintArr(arr1);

            Array.Copy(referenceArray, arr1, referenceArray.Length);
            t1 = DateTime.Now;
            Quicksort(arr1, 0, arr1.Length - 1, ref counter);
            Console.WriteLine(DateTime.Now - t1);
            Console.WriteLine(counter);
            //PrintArr(arr1);

            Array.Copy(referenceArray, arr1, referenceArray.Length);
            counter = 0;
            t1 = DateTime.Now;
            arr1 = MergeSort(arr1, ref counter);
            Console.WriteLine(DateTime.Now - t1);
            Console.WriteLine(counter);
            //PrintArr(arr1);

            Array.Copy(referenceArray, arr1, referenceArray.Length);
            counter = 0;
            t1 = DateTime.Now;
            ShellSort(arr1, ref counter);
            Console.WriteLine(DateTime.Now - t1);
            Console.WriteLine(counter);
            //PrintArr(arr1);

            Array.Copy(referenceArray, arr1, referenceArray.Length);
            counter = 0;
            t1 = DateTime.Now;
            PyramidSort(arr1, ref counter);
            Console.WriteLine(DateTime.Now - t1);
            Console.WriteLine(counter);
            //PrintArr(arr1);

            Console.ReadKey();
        }
    }
}