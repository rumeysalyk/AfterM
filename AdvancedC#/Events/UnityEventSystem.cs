using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Assets
{
    /*
     * Bizim unity event bir class ve biz kendi eventimizi o sınıftan türeticez.
     * O sınıftan türeteceğimiz için yeni bir class a ihtiyaç duyacağız
     */


    public class UnityEventSystem : MonoBehaviour
    {

        [System.Serializable] public class OnClicked : UnityEvent { } // To show functions belong to UnityEventSystem [System.Serializable] keyword is required

        public OnClicked onLeftClicked;
        public OnClicked onRightClicked;

        //SecondWay of setting event function
        public void Start()
        {
            onLeftClicked.AddListener( PrintLeft );
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                //NOTE: Even if add listener on code we should call Invoke 
                onLeftClicked.Invoke(); // Cannot use += operation like 
            }
            if ( Input.GetMouseButtonDown(1) )
            {
                onRightClicked.Invoke();
            }
        }

        public void PrintRight()
        {
            Debug.Log( "In RightClick" );
        }

        public void PrintLeft()
        {
            Debug.Log( "In LeftClick" );
        }
    }
}
