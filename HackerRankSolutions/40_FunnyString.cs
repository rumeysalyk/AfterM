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
     * Complete the 'funnyString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string funnyString(string s)
    {
        char[] temp = new char[s.Length];
        bool flag = true;
        
        for (int i = s.Length-1; i >= 0; i--)
        {
            temp[s.Length - i - 1] = s[i];
        }
        
        for( int i = 0; i< s.Length-1; i++ )
        {
            if( Math.Abs(temp[i]-temp[i+1]) != Math.Abs(s[i]-s[i+1]) )
            {
                flag = false;
                break;
            }
        }
        
        if( flag )
        {
            return "Funny";
        }
        else
        {
            return "Not Funny";
        }
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            string result = Result.funnyString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
