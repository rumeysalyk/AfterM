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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        DateTime dateTime = DateTime.Parse(s);
        
        if( s[9].Equals('P') )
        {
            dateTime = new DateTime( (24 - dateTime.Hour), dateTime.Minute, dateTime.Second );
        }
        else if( s[9].Equals('A') )
        {
            dateTime =new DateTime( (dateTime.Hour - 12 ), dateTime.Minute,dateTime.Second);
        }
        
        return dateTime.TimeOfDay.ToString();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
