// C# program to implement Naive approach
// to remove duplicates
using System;
using System.Collections.Generic;


class GFG
{
   static bool checkarr(int[] A, int[] B)
   {

        int[,] arr = new int[A.Length, 2];

        for (int i = 0; i < A.Length; i++)
        {
            arr[i, 0] = A[i];
            arr[i, 1] = 1;
        }

        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < A.Length; j++)
            {
                if (arr[i, 0] == B[j])
                {
                    arr[i, 1] = 0;
                }
            }
        }

        for (int i = 0; i < A.Length; i++)
        {
            if (arr[i, 1] != 0)
            {
                return false;
            }
        }

        return true;
    }
    public static void Main(String[] args)
	{
        int[] A = { 2, 5, 10, 6, 8, 2, 2 };
        int[] B = { 2, 5, 6, 8, 10, 2, 2 };

        if (checkarr(A, B))
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}


