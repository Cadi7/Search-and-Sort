using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C___Individual
{
    public static class cautari
    {
        public static int[,] arr = new int[1, 1];
        public static int[] arr2 = new int[25];
        public static int[] prime = new int[8];
        public static int maxdivs = 0;
        public static int poz1 = 0;
        public static int poz2 = 0;

        #region Linear Search
        public static int LinearSearch(ref int[] x, int valueToFind)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (valueToFind == x[i])
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region Binary Search

        public static int BinSearch(ref int[] x, int searchValue)
        {
            // Returns index of searchValue in sorted array x, or -1 if not found
            int left = 0;
            int right = x.Length;
            return BinarySearch(ref x, searchValue, left, right);
        }

        public static int BinarySearch(ref int[] x, int searchValue, int left, int right)
        {
            if (right < left)
            {
                return -1;
            }
            int mid = (left + right) >> 1;
            if (searchValue > x[mid])
            {
                return BinarySearch(ref x, searchValue, mid + 1, right);
            }
            else if (searchValue < x[mid])
            {
                return BinarySearch(ref x, searchValue, left, mid - 1);
            }
            else
            {
                return mid;
            }
        }
        #endregion

        #region Interpolation Search

        public static int InterpolationSearch(ref int[] x, int searchValue)
        {
            int low = 0;
            int high = x.Length - 1;
            int mid;

            while (x[low] < searchValue && x[high] >= searchValue)
            {
                mid = low + ((searchValue - x[low]) * (high - low)) / (x[high] - x[low]);

                if (x[mid] < searchValue)
                    low = mid + 1;
                else if (x[mid] > searchValue)
                    high = mid - 1;
                else
                    return mid;
            }

            if (x[low] == searchValue)
                return low;
            else
                return -1; 
        }
        #endregion

        #region Jump Search
        public static int JumpSearch(ref int[] arr, int x)
        {
            int n = arr.Length;

            int step = (int)Math.Sqrt(n);
            int prev = 0;
            while (arr[Math.Min(step, n) - 1] < x)
            {
                prev = step;
                step += (int)Math.Sqrt(n);
                if (prev >= n)
                    return -1;
            }

            while (arr[prev] < x)
            {
                prev++;
                if (prev == Math.Min(step, n))
                    return -1;
            }

            if (arr[prev] == x)
                return prev;

            return -1;
        }
        #endregion

        #region Exponential Search

        public static int binarySearch2(ref int[] arr, int l,
                        int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                
                if (arr[mid] == x)
                    return mid;

               
                if (arr[mid] > x)
                    return binarySearch2(ref arr, l, mid - 1, x);

               
                return binarySearch2(ref arr, mid + 1, r, x);
            }

          
            return -1;
        }
        public static int ExponentialSearch(ref int[] arr, int x, int n)
        {

        
            if (arr[0] == x)
                return 0;

         
            int i = 1;
            while (i < n && arr[i] <= x)
                i = i * 2;

            
            return binarySearch2(ref arr, i / 2,
                               Math.Min(i, n - 1), x);
        }
        #endregion

        #region Fibonacci Search

        public static int min(int x, int y)
        {
            return (x <= y) ? x : y;
        }
        public static int FibonacciSearch(ref int[] arr, int x, int n)
        {
            int fibMMm2 = 0; 
            int fibMMm1 = 1; 
            int fibM = fibMMm2 + fibMMm1; 

            while (fibM < n)
            {
                fibMMm2 = fibMMm1;
                fibMMm1 = fibM;
                fibM = fibMMm2 + fibMMm1;
            }

            int offset = -1;

            while (fibM > 1)
            {
             
                int i = min(offset + fibMMm2, n - 1);

                if (arr[i] < x)
                {
                    fibM = fibMMm1;
                    fibMMm1 = fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                    offset = i;
                }

                else if (arr[i] > x)
                {
                    fibM = fibMMm2;
                    fibMMm1 = fibMMm1 - fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                }

                else
                    return i;
            }

            if (fibMMm1 == 1 && arr[n - 1] == x)
                return n - 1;
            return -1;
        }
        #endregion

        #region maxmin
        public static int FindMax(int[] x)
        {
            int max = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > max) max = x[i];
            }
            return max;
        }


     
        public static int FindMin(int[] x)
        {
            int min = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] < min) min = x[i];
            }
            return min;
        }

        public static int FindMinP(int[] x)
        {
            int min = x[1];
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] < min) min = x[i];
            }
            return min;
        }


        public static bool isPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public static void Prime(int[] x)
        {
            int w = -1;
            for (int i = 0; i < x.Length; i++)
            {
                if (isPrime(x[i]))
                {
                    w++;
                    prime[w] = x[i];
                }
            }
        }

        #endregion


        public static int FindDivisors(int[] x)
        {
            int mostDivisors = 0;
            maxdivs = x[0];
            for (int i = 1; i < x.Length; i++)
            {
              int  currentDivisors = 0; 
                for (int d = 2; d <= x[i] / 2; d++)
                    if (x[i] % d == 0)
                        currentDivisors++;

                if (currentDivisors > mostDivisors)
                {
                    mostDivisors = currentDivisors;
                    maxdivs = x[i];
                }
            }
            return maxdivs;

        }
        #region conversii
       public static void toarray()
        {
            int allocation = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr2[allocation] = arr[i, j];
                    allocation++; 
                }
        }

        public static void tomatrix()
        {

            int allocation = 0;
            for (int i = 0; i < cautari.arr.GetLength(0); i++)
            {
                for (int j = 0; j < cautari.arr.GetLength(1); j++)
                {
                    cautari.arr[i, j] = cautari.arr2[allocation];
                    allocation++;
                }
            }
        }
        #endregion

        public static string initial()
        {
            string matrixString = "";
            for (int i = 0; i < cautari.arr.GetLength(0); i++)
            {
                for (int j = 0; j < cautari.arr.GetLength(1); j++)
                {
                    matrixString += cautari.arr[i,j].ToString();
                    matrixString += " ";
                }

                matrixString += Environment.NewLine;
            }
            return matrixString;
        }
    }
}
