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
     * Complete the 'kaprekarNumbers' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER p
     *  2. INTEGER q
     */

    public static void kaprekarNumbers(int p, int q)
    {
        int count = 0, d;
        long firstNumber = 0, secondNumber = 0, currentNumber = 0;
        string currentString, firstPart, secondPart;

        List<long> numberPack = new List<long>();

        for (long i = p; i <= q; i++)
        {
            currentNumber = i * i;

            currentString = Convert.ToString(currentNumber);
            d = currentString.Length / 2;

            if(  i>=1 && i<=3 )
            {
                firstPart = currentString.Substring(0, 1);
                firstNumber = Int64.Parse(firstPart);
                secondNumber = 0;
            }
            else
            {
                firstPart = currentString.Substring(0, d);
                firstNumber = Int64.Parse(firstPart);
                secondPart = currentString.Substring(d, currentString.Length - d);
                secondNumber = Int64.Parse(secondPart);
            }

            if( firstNumber + secondNumber == i )
            {
                count++;
                numberPack.Add( i );
            }
        }

        if( count == 0 )
        {
            Console.WriteLine( "INVALID RANGE" );
        }
        else
        {
            for ( int i = 0; i < numberPack.Count; i++ )
            {
                Console.Write( numberPack[i] + " " );
            }
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        Result.kaprekarNumbers(p, q);
    }
}
