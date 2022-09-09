using System.Collections;
using UnityEngine;
using UnityEngine.Events;

/*
 * Written by Erkan şenşal youtube video
 *
 */
namespace Assets
{
    public class ParameterizedUnityEventSystems : MonoBehaviour
    {
        [System.Serializable] public class OnPrinted : UnityEvent<int> { }

        public OnPrinted m_onPrinted;
        //SecondWay of setting event function
        public void Start()
        {
            m_onPrinted.AddListener( onPrintValue );
        }
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                m_onPrinted.Invoke(15);
            }
        }
        public void onPrintValue( int x )
        {
            Debug.Log( "Number" + x );
        }

    }
}
