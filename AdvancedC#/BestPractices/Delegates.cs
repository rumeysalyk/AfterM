using UnityEngine;

namespace Assets
{
    public class TestDelegate : MonoBehaviour
    {
        public delegate void Tester(int num);

        public Tester TestDelegateObject;

        public TestDelegate()
        {
            TestDelegateObject = ExampleFunction;

            TestDelegateObject(1254);
            TestDelegateObject?.Invoke(1254); //Second call method

            TestDelegateObject += ExampleFunction2;
            TestDelegateObject(1478);
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
