using System;
using System.Collections;
using UnityEngine;

namespace Assets
{
    public class FuncDelegate : MonoBehaviour
    {
        static Func<int, int, bool> m_funcDelegate = new Func<int, int, bool>( FuncDelegate.Test );

        public void Start()
        {
            bool result = m_funcDelegate(25, 5);
            Debug.Log( result );

        }

        //This function controls the first number is divisible to the second number
        public static bool Test(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                if (firstNumber % secondNumber == 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

    }


}
