using System;
using System.Collections;
using UnityEngine;

namespace Assets
{
    public class ActionDelegate : MonoBehaviour
    {
        /*
        * The Action Delegate is needed when we need to invoke a method that doesnt have any return type.
        * Action Delegate is capable of taking a maximum of 16 parameters as arguments, which means it has 16 overload methods.
        * Syntax : Action<parameter list> Object_name= new Action <parameter list>(method_name);
        */
        static Action<string, string> actionDelegate = new Action<string, string>( Concat ); 

        void Start()
        {
            actionDelegate( "Night", " Owl");
        }

        public static void Concat( string a, string b )
        {
            a += b;
            Debug.Log( "Result: "+ a );
        }
    }
}
