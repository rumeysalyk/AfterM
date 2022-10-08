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
     * Complete the 'appendAndDelete' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. STRING t
     *  3. INTEGER k
     */


    public static string appendAndDelete(string s, string t, int k)
        {
            int count = 0, numberOfAppendOperation = 0, numberOfDeleteOperation = 0 ,length = s.Length, i=0;


            if( s.Length > t.Length )
            {
                while (true)
                {
                    if (t.Length != i && s[i] == t[i])
                    {
                        i++;
                        continue;
                    }
                    else
                    {
                        numberOfAppendOperation = t.Length - i;
                        if (i == t.Length)
                        {
                            numberOfDeleteOperation = s.Length - i;
                        }
                        else
                        {
                            numberOfDeleteOperation = s.Length - i - 1;
                        }
                        count = numberOfDeleteOperation + numberOfAppendOperation;
                        break;
                    }
                }
            } 
            else if( s.Length == t.Length )
            {
                count =  s.Length*2 + 1;
            }
            else
            {
                if ( k <= s.Length && k <= t.Length )
                    return "Yes";
                else
                    return "No";
            }

            if (k >= count)
                return "Yes";
            else
                return "No";
        }
 
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.appendAndDelete(s, t, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
