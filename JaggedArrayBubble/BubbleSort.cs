using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayBubble
{
    public interface IComparer
    {
        int Compare(int[] arr1, int[] arr2);
    }

    public class CompareBySum : IComparer
    {
        public int Compare(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr2 == null)
                throw new ArgumentNullException();

            if (arr1.Sum() > arr2.Sum())
                return 1;
            else if (arr1.Sum() < arr2.Sum())
                return -1;
            else return 0;
        }


    }

    public class CompareByMaxValue : IComparer
    {
        public int Compare(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr2 == null)
                throw new ArgumentNullException();

            if (arr1.Max() > arr2.Max())
                return 1;
            else if (arr1.Max() < arr2.Max())
                return -1;
            else return 0;
        }
    }

    public class CompareByMinValue : IComparer
    {
        public int Compare(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr2 == null)
                throw new ArgumentNullException();

            if (arr1.Min() > arr2.Min())
                return 1;
            else if (arr1.Min() < arr2.Min())
                return -1;
            else return 0;
        }
    }

    public class SortJaggedArray
    {
        public static void SortArrayByDecrease(int[][] arr, IComparer compare)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (compare.Compare(arr[i], arr[j]) == -1)
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }

        public static void SortArrayByIncrease(int[][] arr, IComparer compare)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (compare.Compare(arr[i], arr[j]) == 1)
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }

        public static void Swap(ref int[] arr1, ref int[] arr2)
        {
            var temp = arr1;
            arr1 = arr2;
            arr2 = temp;
        }
    }

}
