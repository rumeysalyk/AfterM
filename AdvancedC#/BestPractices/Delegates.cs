using UnityEngine;
using System;

namespace Assets
{
    public class TestDelegate : MonoBehaviour
    {
        public Action TestDelegateObject; //It delegate the methods which there is no return type and no parameter

        public void Start()
        {
            TestDelegateObject = ExampleFunction2;
            TestDelegateObject();
            //TestDelegateObject = () => { }; //anonymous function
        }

        public void ExampleFunction(int a_num)
        {
            UnityEngine.Debug.LogError("Number1: " + a_num);
        }

        public void ExampleFunction2()
        {
            UnityEngine.Debug.LogError("Number");
        }
    }
}
