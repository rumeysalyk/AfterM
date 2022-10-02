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
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */
    public static int pickingNumbers( List<int> a )
    {
        int maxLength = 0, diff;
        bool flag = true;

        List<int> tempList = new List<int>();
        
        for ( int i = 0; i < a.Count; i++ )
        {
            tempList.Add( a[i] );

            for ( int j = 0; j < a.Count ; j++ )
            {
                if( j != i )
                {  
                    diff = Math.Abs( a[i] - a[j] );

                    if ( diff <= 1 )
                    {
                        foreach ( var element in tempList )
                        {
                            diff = Math.Abs(a[j] - element);

                            if ( diff > 1 )
                            {
                                flag = false;
                            }
                        }
                        if ( flag )
                        {
                            tempList.Add( a[j] );
                        }
                        flag = true;
                    }
                }

            }

            if ( maxLength < tempList.Count )
            {
                maxLength = tempList.Count;
            }
            
            tempList.Clear();
            flag = true;
        }
        return maxLength;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
