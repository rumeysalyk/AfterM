using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long swap = 0;
        
        long maxSum = 0, minSum = 0;

        for( int i=0;i<arr.Count; i++ )
        {
            for( int j= i+1; j <arr.Count; j++ )
            {
                if( arr[i] > arr[j] )
                {
                    swap = arr[i];
                    arr[i] =  arr[j];
                    arr[j] = Convert.ToInt32(swap);
                }
            }
        }
        
        
        for( int i=0;i<4; i++ )
        {
            minSum += arr[i];
        }
        
        for( int i=1; i<5; i++)
        {
            maxSum += arr[i];
        }
        
        Console.WriteLine( minSum + " " + maxSum );
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
