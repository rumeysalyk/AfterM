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
     * Complete the 'equalizeArray' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int equalizeArray(List<int> arr)
    {
        int maxNumber = 0, count, deletionCount = 0, max = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            count = 0;
            for (int j = i + 1; j < arr.Count; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    if (count > max)
                    {
                        max = count;
                        maxNumber = arr[i];
                    }
                }
            }
        }

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] != maxNumber)
            {
                deletionCount++;
            }
        }
        if (max == 0)
        {
            deletionCount = arr.Count - 1;
        }
        return deletionCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.equalizeArray(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
