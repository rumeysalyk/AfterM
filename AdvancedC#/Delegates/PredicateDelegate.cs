using System;
using System.Collections;
using UnityEngine;

namespace Assets
{
    public class PredicateDelegate : MonoBehaviour
    {
        /*
         * It represents a method containing a set of criteria and checks 
         *  whether the passed parameter meets those criteria.
         *  
         * Syntax: Predicate<parameterlist> Object_name= new Predicate<parameterlist>(method_name);
         *         public delegate bool Predicate<in T>(T obj);
        */

        Predicate<int> m_predicateDelegate = new Predicate<int>( PasswordLengthValidation );

        void Start()
        {
            bool result = m_predicateDelegate( 12547836 );
            Debug.Log( "Result: " + result );
        }

        public static bool PasswordLengthValidation( int number )
        {
            int count = 0;

            while( number > 0 )
            {
                count++;
                number = number / 10;
            }

            Debug.Log("Count: " + count);

            if ( count > 8 || count < 8 )
                return false;
            else
                return true;
        }

    }
}
