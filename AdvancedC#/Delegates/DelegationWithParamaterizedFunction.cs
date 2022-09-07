using System.Collections;
using UnityEngine;

namespace Assets
{
    public class DelegationWithParamaterizedFunction : MonoBehaviour
    {
        public delegate int Calculator( int x, int y );

        public void Start()
        {
            Calculator calculator = Sum;

            int result = calculator( 12, 15 );

            Debug.Log( "Result: " + result );

            calculator = Multiply;
            result = calculator( 5, 3 );
            Debug.Log("Result: " + result);

            //Third way of calling delegate

            calculator = new Calculator( Divide );
            //Executes the specified delegate on the thread that owns the control's underlying window handle : taken by microsoft document
            result = calculator.Invoke( 74, 2 );

            Debug.Log("Result: " + result);
        }

        public int Sum( int x, int y )
        {
            return x + y; 
        }
        public int Substract( int x, int y )
        {
            return x - y;
        }
        public int Multiply( int x, int y )
        {
            return x * y;
        }

        public int Divide( int x, int y)
        {
            if( x > y  && y!= 0)
                return x / y;
            return 0;
        }
    }
}