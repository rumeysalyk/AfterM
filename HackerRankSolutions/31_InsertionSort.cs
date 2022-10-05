using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Solution { 
    public static void insertionSort (int[] A) { 
        int temp = 0; 
        for (var i = 0; i < A.Length; i++) { 
            for( int j=0; j<i; j++ )
            {
                if( A[i] < A[j] )
                {
                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }
        } 
        Console.WriteLine(string.Join(" ", A)); 
    }

    static void Main(string[] args) { 
        Console.ReadLine(); 
        int [] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
        insertionSort(_ar); 
    }
}

