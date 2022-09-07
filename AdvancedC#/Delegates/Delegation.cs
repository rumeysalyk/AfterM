using System.Collections;
using UnityEngine;

namespace Assets
{
    public class Delegation : MonoBehaviour
    {
        /*         
         * Task:
         * Delegates keeps functions like int which keep a integer number
         * 1-Define delegate
         * 2-Create delegate object
         * Not: If you already have added a function into delegateObject, cannot add that again
        */

        public delegate void DelegateObject(); //defintion : If the signature of a function is the same as this delegate, delegate can be used
        public DelegateObject m_delegation; //object
        private void Start()
        {
            m_delegation = Delegate1;
            m_delegation += Delegate2; //sum of two function like sum of two numbers
            m_delegation += Delegate3;
            //AddDelegation( Delegate3 );
            m_delegation(); //calling

            Debug.Log( "*******After Removing******" );
            m_delegation -= Delegate2; //delete operation

            if( m_delegation is not null )
            {
                m_delegation();
            }
        }

        private void Delegate1()
        {
            Debug.Log( "Delegate Function 1" );
        }

        private void Delegate2()
        {
            Debug.Log("Delegate Function 2");
        }

        private void Delegate3()
        {
            Debug.Log("Delegate Function 3");
        }

        public void AddDelegation( DelegateObject a_delegate )
        {
            m_delegation += a_delegate;
        }

        public void RemoveDelegation( DelegateObject a_delegate )
        {
            m_delegation -= a_delegate;
        }
    }
}
