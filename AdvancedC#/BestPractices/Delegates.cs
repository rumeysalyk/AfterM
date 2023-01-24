using UnityEngine;
using System;

namespace Assets
{
    public class TestDelegate : MonoBehaviour
    {
        public EventHandler TestDelegateObject;

        public void Start()
        {
            TestDelegateObject( this, EventArgs.Empty );//sender,sended data
        }

        public void ExampleFunction(int a_num)
        {
            UnityEngine.Debug.LogError("Number1: " + a_num);
        }

        public void ExampleFunction2(int a_num)
        {
            UnityEngine.Debug.LogError("Number2: " + a_num);
        }
    }
}
