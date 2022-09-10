using System.Collections;
using UnityEngine;

namespace Assets
{
    public class GenericDelegate : MonoBehaviour
    {
        public delegate void Delegation<T>( T a_param1, T  a_param2);

        public void Start()
        {
            Delegation<int> m_intDelegate = new Delegation<int>( SumInt );
            m_intDelegate( 23, 41 );

            Delegation<string >m_stringDelegate = new Delegation<string>( SumString );
            m_stringDelegate("Rumeysa ", "Layık");
        }


        public void SumString( string a_param1, string a_param2 )
        {
            Debug.Log( a_param1 + a_param2 );
        }


        public void SumInt( int a_param1, int a_param2 )
        {
            Debug.Log( a_param1 + a_param2 );
        }
    }
}
