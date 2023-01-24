using UnityEngine;

namespace Assets
{
    public class TestDelegate : MonoBehaviour
    {
        public delegate void Tester(int num);

        public event Tester TestDelegateObject;

        public void Start()
        {
            TestDelegateObject = ExampleFunction;

            TestDelegateObject(1254);
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
