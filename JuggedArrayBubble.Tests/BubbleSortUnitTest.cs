using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JaggedArrayBubble;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace JuggedArrayBubble.Tests
{
    [TestClass]
    public class BubbleSortUnitTest
    {
        [TestMethod]
        public void CheckIncreaseSortJArray_JaggedArrayAndCompareBySum_ArraySortedByIncreseOfSum()
        {

            int[][] arrangeArray = new int[3][];
            arrangeArray[0] = new int[] { 1, 6, 3 };
            arrangeArray[1] = new int[] { 2, 4 };
            arrangeArray[2] = new int[] { 2, 4, 6, 8 };


            int[][] actArray = new int[3][];
            actArray[0] = new int[] { 2, 4 };
            actArray[1] = new int[] { 1, 6, 3 };
            actArray[2] = new int[] { 2, 4, 6, 8 };

            CompareBySum compare = new CompareBySum();
            SortJaggedArray.SortArrayByIncrease(arrangeArray, compare);

            Assert.AreEqual(arrangeArray[0], actArray[0]);
            Assert.AreEqual(arrangeArray[1], actArray[1]);
            Assert.AreEqual(arrangeArray[2], actArray[2]);
        }

        [TestMethod]
        public void CheckDecreaseSortJArray_JaggedArrayAndCompareBySum_ArraySortedByDecreaseOfSum()
        {

            int[][] arrangeArray = new int[3][];
            arrangeArray[0] = new int[] { 1, 3, 5 };
            arrangeArray[1] = new int[] { 2, 4 };
            arrangeArray[2] = new int[] { 2, 4, 6, 8 };


            int[][] actArray = new int[3][];
            actArray[0] = new int[] { 2, 4, 6, 8 };
            actArray[1] = new int[] { 1, 3, 5 };
            actArray[2] = new int[] { 2, 4 };

            CompareBySum compare = new CompareBySum();
            SortJaggedArray.SortArrayByDecrease(arrangeArray, compare);

            Assert.AreEqual(arrangeArray[0], actArray[0]);
            Assert.AreEqual(arrangeArray[1], actArray[1]);
            Assert.AreEqual(arrangeArray[2], actArray[2]);
        }

        [TestMethod]
        public void CheckIncreaseSortJArray_JaggedArrayAndCompareByMaxValue_ArraySortedByIncreseOfMaxValue()
        {

            int[][] arrangeArray = new int[3][];
            arrangeArray[0] = new int[] { 1, 3, 5 };
            arrangeArray[1] = new int[] { 2, 4 };
            arrangeArray[2] = new int[] { 2, 4, 6, 8 };


            int[][] actArray = new int[3][];
            actArray[0] = new int[] { 2, 4 };
            actArray[1] = new int[] { 1, 3, 5 };
            actArray[2] = new int[] { 2, 4, 6, 8 };

            CompareByMaxValue compare = new CompareByMaxValue();
            SortJaggedArray.SortArrayByIncrease(arrangeArray, compare);

            Assert.AreEqual(arrangeArray[0], actArray[0]);
            Assert.AreEqual(arrangeArray[1], actArray[1]);
            Assert.AreEqual(arrangeArray[2], actArray[2]);
        }

        [TestMethod]
        public void CheckDecreaseSortJArray_JaggedArrayAndCompareByMaxValue_ArraySortedByDecreaseOfMaxValue()
        {

            int[][] arrangeArray = new int[3][];
            arrangeArray[0] = new int[] { 1, 3, 5 };
            arrangeArray[1] = new int[] { 2, 4 };
            arrangeArray[2] = new int[] { 2, 4, 6, 8 };


            int[][] actArray = new int[3][];
            actArray[0] = new int[] { 2, 4, 6, 8 };
            actArray[1] = new int[] { 1, 3, 5 };
            actArray[2] = new int[] { 2, 4 };

            CompareByMaxValue compare = new CompareByMaxValue();
            SortJaggedArray.SortArrayByDecrease(arrangeArray, compare);

            Assert.AreEqual(arrangeArray[0], actArray[0]);
            Assert.AreEqual(arrangeArray[1], actArray[1]);
            Assert.AreEqual(arrangeArray[2], actArray[2]);
        }


        [TestMethod]
        public void CheckDecreaseSortJArray_JaggedArrayAndCompareByMinValue_ArraySortedByDecreaseOfMinValue()
        {

            int[][] arrangeArray = new int[3][];
            arrangeArray[0] = new int[] { 1, 3, 5 };
            arrangeArray[1] = new int[] { 2, 4 };
            arrangeArray[2] = new int[] { 2, 4, 6, 8 };


            int[][] actArray = new int[3][];
            actArray[0] = new int[] { 2, 4 };
            actArray[1] = new int[] { 2, 4, 6, 8 };
            actArray[2] = new int[] { 1, 3, 5 };

            CompareByMinValue compare = new CompareByMinValue();
            SortJaggedArray.SortArrayByDecrease(arrangeArray, compare);

            Assert.AreEqual(arrangeArray[0], actArray[0]);
            Assert.AreEqual(arrangeArray[1], actArray[1]);
            Assert.AreEqual(arrangeArray[2], actArray[2]);
        }

        [TestMethod]
        public void CheckIncreaseSortJArray_JaggedArrayAndCompareByMinValue_ArraySortedByIncreseOfMinValue()
        {

            int[][] arrangeArray = new int[3][];
            arrangeArray[0] = new int[] { 1, 3, 5 };
            arrangeArray[1] = new int[] { 2, 4 };
            arrangeArray[2] = new int[] { 2, 4, 6, 8 };


            int[][] actArray = new int[3][];
            actArray[0] = new int[] { 1, 3, 5 };
            actArray[1] = new int[] { 2, 4 };
            actArray[2] = new int[] { 2, 4, 6, 8 };

            CompareByMinValue compare = new CompareByMinValue();
            SortJaggedArray.SortArrayByIncrease(arrangeArray, compare);

            Assert.AreEqual(arrangeArray[0], actArray[0]);
            Assert.AreEqual(arrangeArray[1], actArray[1]);
            Assert.AreEqual(arrangeArray[2], actArray[2]);
        }
    }
}
