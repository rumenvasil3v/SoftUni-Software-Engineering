
// C# implementation to find longest
// increasing subsequence in O(n Log n)
// time.
using System;

class GFG
{

    // Binary search
    static int GetCeilIndex(int[] arr, int[] T, int l,
                            int r, int key)
    {

        while (r - l > 1)
        {
            int m = l + (r - l) / 2;

            if (arr[T[m]] >= key)
                r = m;
            else
                l = m;
        }

        return r;
    }

    static int LongestIncreasingSubsequence(
        int[] arr, int n)
    {

        // Add boundary case, when array n is zero
        // Depend on smart pointers

        int[] tailIndices = new int[n];

        // Initialized with 0
        for (int i = 0; i < n; i++)
            tailIndices[i] = 0;

        int[] prevIndices = new int[n];

        // initialized with -1
        for (int i = 0; i < n; i++)
            prevIndices[i] = -1;

        // it will always point to empty
        // location
        int len = 1;

        for (int i = 1; i < n; i++)
        {
            if (arr[i] < arr[tailIndices[0]])

                // new smallest value
                tailIndices[0] = i;

            else if (arr[i] > arr[tailIndices[len - 1]])
            {

                // arr[i] wants to extend
                // largest subsequence
                prevIndices[i] = tailIndices[len - 1];
                tailIndices[len++] = i;
            }
            else
            {

                // arr[i] wants to be a potential
                // condidate of future subsequence
                // It will replace ceil value in
                // tailIndices
                int pos = GetCeilIndex(arr,
                                       tailIndices, -1, len - 1, arr[i]);

                prevIndices[i] = tailIndices[pos - 1];
                tailIndices[pos] = i;
            }
        }

        Console.Write("LIS of given input");

        for (int i = tailIndices[len - 1]; i >= 0;
             i = prevIndices[i])
            Console.Write(arr[i] + " ");

        Console.WriteLine();

        return len;
    }

    // Driver code
    public static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = arr.Length;

        Console.Write("LIS size\n" + LongestIncreasingSubsequence(arr, n));
    }
}
