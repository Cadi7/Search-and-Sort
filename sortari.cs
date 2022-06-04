using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___Individual
{


    public static class Extensions
    {
        /// <summary>
        /// General way to convert a 2D to 1D
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int[] ToArray(this int[][] matrix)
        {
            int rows = matrix.Length;
            int columns = matrix[0].Length;
            return matrix.ToArray(rows, columns);
        }

        public static int[] ToArray(this int[][] matrix, int rows, int cols)
        {
            int[] array = new int[rows * cols];
            int k = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    array[k++] = matrix[i][j];
            return array;
        }

        public static int[][] ToMatrix(this int[] array, int rows, int cols)
        {
            int k = 0;
            int[][] matrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = array[k++];
                }
            }
            return matrix;
        }


    }
    public class Sort : IDisposable
    {

        int[][] SortedMatrix;
        public enum SortTypes : int
        {
            SelectionSort = 0,
            InsertionSort = 1,
            BubbleSort = 2,
            ShellSort = 3,
            MergeSort = 4,
            HeapSort = 5,
            QuickSort = 6,
            ComboSort = 7,
            RadixSort = 8,
            CocktailSort = 9,
        }

        public void Dispose()
        {
            SortedMatrix = null;
        }

        /// <summary>
        /// Sorting class for matrices.
        /// </summary>
        /// <param name="matrix">The matrix</param>
        /// <param name="method">The method of sorting</param>
        /// 

        private void MethodSort(int[][] matrix, int rows, int columns, SortTypes method, Func<int, int, int> comparator)
        {
            int[] array = matrix.ToArray(rows, columns);
            switch (method)
            {
                case SortTypes.BubbleSort:
                    BubbleSort(ref array);
                    break;
                case SortTypes.InsertionSort:
                    InsertionSort(ref array);
                    break;
                case SortTypes.QuickSort:
                    QuickSort(ref array, 0, array.Length - 1, Comparator);
                    break;
                case SortTypes.SelectionSort:
                    SelectionSort(ref array);
                    break;
                case SortTypes.RadixSort:
                    RadixSort(ref array, 4);
                    break;
                case SortTypes.ComboSort:
                    ComboSort(ref array);
                    break;
                case SortTypes.CocktailSort:
                    CocktailSort(ref array);
                    break;
                case SortTypes.MergeSort:
                    MergeSort(ref array, 0, array.Length-1);
                    break;
                case SortTypes.HeapSort:
                    Heapsort(ref array);
                    break;
                case SortTypes.ShellSort:
                    ShellSort(ref array);
                    break;
            }
            this.SortedMatrix = array.ToMatrix(rows, columns);
            Func<int, int, int> function = Comparator;
        }

        public static int Comparator(int a, int b)
        {
            return Convert.ToInt32(a > b);
        }


        public Sort(int[][] matrix, SortTypes method, Func<int, int, int> comparator = null)
        {
            int rows = matrix.Length;
            int columns = matrix[0].Length;
            MethodSort(matrix, rows, columns, method, comparator);
        }

        public Sort(int[][] matrix, int rows, int columns, SortTypes method, Func<int, int, int> comparator = null) =>
            MethodSort(matrix, rows, columns, method, comparator);

        public int[][] Get()
        {
            return SortedMatrix;
        }

        public static void siftDown(ref int[] array, int root, int bottom)
        {
            bool done = false;
            int maxChild;
            int temp;

            while ((root * 2 <= bottom) && (!done))
            {
                if (root * 2 == bottom)
                    maxChild = root * 2;
                else if (array[root * 2] > array[root * 2 + 1])
                    maxChild = root * 2;
                else
                    maxChild = root * 2 + 1;

                if (array[root] < array[maxChild])
                {
                    temp = array[root];
                    array[root] = array[maxChild];
                    array[maxChild] = temp;
                    root = maxChild;
                }
                else
                {
                    done = true;
                }
            }
        }

        private void Heapsort(ref int[] array)
        {
            int i;
            int temp;
            int n = array.Length;

            for (i = (n / 2) - 1; i >= 0; i--)
            {
                siftDown(ref array, i, n);
            }

            for (i = n - 1; i >= 1; i--)
            {
                temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                siftDown(ref array, 0, i - 1);
            }
        }

        private void SelectionSort(ref int[] array)
        {
            int i, j;
            int min, temp;

            for (i = 0; i < array.Length - 1; i++)
            {
                min = i;
                for (j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }
        private void BubbleSort(ref int[] array)
        {
            for (int pass = 1; pass < array.Length - 1; pass++)
            {

                for (int i = 0; i < array.Length - pass; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }
        public static void RadixSort(ref int[] x, int bits)
        {

            int[] b = new int[x.Length];
            int[] b_orig = b;

            int rshift = 0;
            for (int mask = ~(-1 << bits); mask != 0; mask <<= bits, rshift += bits)
            {
             
                int[] cntarray = new int[1 << bits];

                for (int p = 0; p < x.Length; ++p)
                {
                    int key = (x[p] & mask) >> rshift;
                    ++cntarray[key];
                }

                for (int i = 1; i < cntarray.Length; ++i)
                    cntarray[i] += cntarray[i - 1];
                for (int p = x.Length - 1; p >= 0; --p)
                {
                    int key = (x[p] & mask) >> rshift;
                    --cntarray[key];
                    b[cntarray[key]] = x[p];
                }
                int[] temp = b; b = x; x = temp;
            }
        }
        private void QuickSort(ref int[] array, int low, int high, Func<int, int, int> comparator)
        {
            if (low < high)
            {
                int p = Partition(ref array, low, high, comparator);
                QuickSort(ref array, low, p - 1, comparator);
                QuickSort(ref array, p + 1, high, comparator);
            }
        }

        void SwapArrayList(ref int[] array, int pos1, int pos2)
        {
            int temp = array[pos1];
            array[pos1] = array[pos2];
            array[pos2] = temp;
        }

        int Partition(ref int[] array, int low, int high, Func<int, int, int> comparator)
        {
            int pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                try
                {
                    if (comparator(array[j], pivot) <= 0)
                    {
                        i++;
                        SwapArrayList(ref array, i, j);
                    }
                }
                catch { return 0; }
            }
            SwapArrayList(ref array, i + 1, high);
            return i + 1;
        }

        public static void BucketSort(ref int[] x)
        {
            if (x == null || x.Length <= 1)
                return;

            int maxValue = x[0];
            int minValue = x[0];

            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > maxValue)
                    maxValue = x[i];

                if (x[i] < minValue)
                    minValue = x[i];
            }


            LinkedList<int>[] bucket = new LinkedList<int>[maxValue - minValue + 1];

            for (int i = 0; i < x.Length; i++)
            {
                if (bucket[x[i] - minValue] == null)
                    bucket[x[i] - minValue] = new LinkedList<int>();

                bucket[x[i] - minValue].AddLast(x[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<int> node = bucket[i].First;

                    while (node != null)
                    {
                        x[k] = node.Value;
                        node = node.Next;
                        k++;
                    }
                }
            }
        }


        public static void MergeSort(ref int[] x, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(ref x, left, middle);
                MergeSort(ref x, middle + 1, right);
                Merge(ref x, left, middle, middle + 1, right);
            }
        }

        public static void Merge(ref int[] x, int left, int middle, int middle1, int right)
        {
            int oldPosition = left;
            int size = right - left + 1;
            int[] temp = new int[size];
            int i = 0;

            while (left <= middle && middle1 <= right)
            {
                if (x[left] <= x[middle1])
                    temp[i++] = x[left++];
                else
                    temp[i++] = x[middle1++];
            }
            if (left > middle)
                for (int j = middle1; j <= right; j++)
                    temp[i++] = x[middle1++];
            else
                for (int j = left; j <= middle; j++)
                    temp[i++] = x[left++];
            Array.Copy(temp, 0, x, oldPosition, size);
        }

        public static void InsertionSort(ref int[] x)
        {
            int n = x.Length - 1;
            int i, j, temp;

            for (i = 1; i <= n; ++i)
            {
                temp = x[i];
                for (j = i - 1; j >= 0; --j)
                {
                    if (temp < x[j]) x[j + 1] = x[j];
                    else break;
                }
                x[j + 1] = temp;
            }
        }

        public static void ShellSort(ref int[] x)
        {
            int i, j, temp;
            int increment = 3;

            while (increment > 0)
            {
                for (i = 0; i < x.Length; i++)
                {
                    j = i;
                    temp = x[i];

                    while ((j >= increment) && (x[j - increment] > temp))
                    {
                        x[j] = x[j - increment];
                        j = j - increment;
                    }

                    x[j] = temp;
                }

                if (increment / 2 != 0)
                {
                    increment = increment / 2;
                }
                else if (increment == 1)
                {
                    increment = 0;
                }
                else
                {
                    increment = 1;
                }
            }
        }
        public static void CocktailSort(ref int[] x)
        {
            for (int k = x.Length - 1; k > 0; k--)
            {
                bool swapped = false;
                for (int i = k; i > 0; i--)
                    if (x[i] < x[i - 1])
                    {
                        // swap
                        int temp = x[i];
                        x[i] = x[i - 1];
                        x[i - 1] = temp;
                        swapped = true;
                    }

                for (int i = 0; i < k; i++)
                    if (x[i] > x[i + 1])
                    {
                        // swap
                        int temp = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = temp;
                        swapped = true;
                    }

                if (!swapped)
                    break;
            }
        }

        public static int newGap(int gap)
        {
            gap = gap * 10 / 13;
            if (gap == 9 || gap == 10)
                gap = 11;
            if (gap < 1)
                return 1;
            return gap;
        }
        public static void ComboSort(ref int[] x)
        {
            int gap = x.Length;
            bool swapped;
            do
            {
                swapped = false;
                gap = newGap(gap);
                for (int i = 0; i < (x.Length - gap); i++)
                {
                    if (x[i] > x[i + gap])
                    {
                        swapped = true;
                        int temp = x[i];
                        x[i] = x[i + gap];
                        x[i + gap] = temp;
                    }
                }
            } while (gap > 1 || swapped);
        }

    }
   

    public static class sortari
    {
        public static int[][] a;
        public static int[][] b;
        public static int[] array;
        public static int n = 0;
        public static int m = 0;
        public static int[] a2 = new int[sortari.m * sortari.n];
        public static int a_n = sortari.m * sortari.n - 1;
    }

    public static class parcurgeri
    {
        public static void serpuit()
        {

            int m = sortari.m;
            int n = sortari.n;
            int i, k = 0, l = 0, arr_n = 0;
            int[] arr = new int[sortari.m * sortari.n];
            int allocation = 0;
            for (i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[allocation] = sortari.a[i][j];
                    allocation++;
                }
            }
            
            for (i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < m; j++)
                        sortari.a[i][j] = arr[arr_n++];
                }
                else
                {
                    for (int j = m - 1; j >= 0; j--)
                        sortari.a[i][j] = arr[arr_n++];
                }
            }
        }

       

        public static void spirala()
        {
            int m = sortari.m;
            int n = sortari.n;  
            int i, k = 0, l = 0, arr_n = 0;
            int[] arr = new int[sortari.m * sortari.n];
        int allocation = 0;
            for (i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[allocation] = sortari.a[i][j];
                    allocation++;
                }
            }
            while (k < m && l < n)
            {
                for (i = l; i < n; ++i)
                {
                    // cout << A[k][i];
                    sortari.a[k][i] = arr[arr_n++];
                }
                k++;

                for (i = k; i < m; ++i)
                {
                    // cout << A[i][n-1];
                    sortari.a[i][n - 1] = arr[arr_n++];
                }
                n--;

                if (k < m)
                {
                    for (i = n - 1; i >= l; --i)
                    {
                        // cout << A[m-1][i];
                        sortari.a[m - 1][i] = arr[arr_n++];
                    }
                    m--;
                }

                if (l < n)
                {
                    for (i = m - 1; i >= k; --i)
                    {
                        // cout << A[i][l];
                        sortari.a[i][l] =arr[arr_n++];
                    }
                    l++;
                }
            }
        }

        public static void diagonala()
        {
            static void SwapNum(int x, int y)
            {
                int tempswap = x;
                x = y;
                y = tempswap;
            }

            int m = sortari.m;
            int n = sortari.n;
            int i, k = 0, l = 0, arr_n = 0;
            int[] arr = new int[sortari.m * sortari.n];
            int allocation = 0;
            for (i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[allocation] = sortari.a[i][j];
                    allocation++;
                }
            }

            for ( i = 0; i < m; i++)
            {
                int sm = sortari.a[i][i];
                int pos = i;

 
                for (int j = i + 1; j < n; j++)
                {
                    if (sm > sortari.a[j][j])
                    {
                        sm = sortari.a[j][j];
                        pos = j;
                    }
                }

                SwapNum(sortari.a[i][i], sortari.a[pos][pos]);
            }
        }


    }
}
