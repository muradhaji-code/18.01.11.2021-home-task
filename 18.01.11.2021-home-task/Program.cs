using System;

namespace _18._01._11._2021_home_task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //int[] arr = new int[] { 1, 3, 5, 7, 9 };
            //Console.WriteLine(SumOfArray(arr));
            #endregion

            #region Task 2
            //int[] arr = new int[] { 7, 8, 3, 7, 4, 3, 5};
            //Console.WriteLine(CountDuplicates(arr));
            #endregion

            #region Task 3
            //int[] arr = new int[] { 7, 8, 3, 7, 4, 3, 5 };
            //Console.WriteLine(isArrayContains(arr, 5));
            #endregion

            #region Task 4
            //int[] arr = new int[] { 7, 8, 3, 7, 4, 3, 5, 6, 2 };

            //arr = MyReverseWithReturn(arr);
            //MyReverseWithRef(ref arr);
            //Array.Reverse(arr);

            //foreach (int item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region Task 5
            //int[] arr1 = new int[] { 2, 4, 6 };
            //int[] arr2 = new int[] { 1, 3, 5 };

            //int[] arr3 = ConcatAndSortArrays(arr1, arr2);

            //foreach (int item in arr3)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region Task 6
            //MinAndMaxOfArray(new int[] { 4, 6, 9, 1, 3, 2, 7, 5, });
            #endregion

            #region Task 7
            int[] arr = new int[] { 7, 8, 3, 7, 4, 3, 5, 6, 2 };
            //SplitArray(arr);
            #endregion

            #region Task 8
            Console.WriteLine(ShortenSentence("Lorem Ipsum is simply dummy text of the printing and typesetting industry."));
            #endregion
        }

        static int SumOfArray(int[] arr)
        {
            int sum = 0;
            foreach (int x in arr)
            {
                sum += x;
            }
            return sum;
        }
        static int CountDuplicates(int[] arr)
        {
            int count = 0, temp = 0;
            Array.Sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    temp++;
                }
                else
                {
                    count += temp > 0 ? temp + 1 : temp;
                    temp = 0;
                }
            }
            count += temp > 0 ? temp + 1 : temp;
            return count;
        }

        static bool isArrayContains(int[] arr, int x)
        {
            foreach (int item in arr)
            {
                if (item == x)
                {
                    return true;
                }
            }
            return false;
        }

        static int[] MyReverseWithReturn(int[] arr)
        {
            int i = 0, j = arr.Length - 1, temp;
            while (i <= j)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            return arr;
        }
        static void MyReverseWithRef(ref int[] arr)
        {
            int i = 0, j = arr.Length - 1, temp;
            while (i <= j)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }

        static int[] ConcatAndSortArrays(int[] arr1, int[] arr2)
        {
            int[] newarr = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                newarr[2 * i] = arr1[i];
                newarr[2 * i + 1] = arr2[i];
            }
            Array.Sort(newarr);
            Array.Reverse(newarr);
            return newarr;
        }

        static void MinAndMaxOfArray(int[] arr)
        {
            int min = arr[0], max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                min = arr[i] < min ? arr[i] : min;
                max = arr[i] > max ? arr[i] : max;
            }
            Console.WriteLine($"Min: {min}, Max: {max}");
        }

        static void SplitArray(int[] arr)
        {
            int[] even = new int[0], odd = new int[0];
            foreach (int item in arr)
            {
                if (item % 2 == 1)
                {
                    Array.Resize(ref odd, odd.Length + 1);
                    odd[odd.Length - 1] = item;
                }
                else
                {
                    Array.Resize(ref even, even.Length + 1);
                    even[even.Length - 1] = item;
                }
            }
            Console.Write("Odd: ");
            foreach (int item in odd)
            {
                Console.Write(item + " ");
            }
            Console.Write("\nEven: ");
            foreach (int item in even)
            {
                Console.Write(item + " ");
            }
        }

        static string ShortenSentence(string sentence)
        {
            if(sentence.Length > 50)
            {
                return sentence.Substring(0, 50) + "...";
            } else
            {
                return sentence;
            }
        }
    }
}