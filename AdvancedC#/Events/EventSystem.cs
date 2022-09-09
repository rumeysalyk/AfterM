using System.Collections;
using UnityEngine;

namespace Assets
{
    public class EventSystem : MonoBehaviour
    {
        public delegate void onClicked();
        public event onClicked onLeftClicked;
        public event onClicked onRightClicked;

        // Use this for initialization
        void Start()
        {
            onLeftClicked += PrintLeft;
            onRightClicked += PrintRight;
        }

        // Update is called once per frame
        void Update()
        {
            if( Input.GetMouseButtonDown(0) )
            {
                onLeftClicked();
            }
            else if( Input.GetMouseButtonDown(1) )
            {
                onRightClicked();
            }
        }

        public void PrintRight()
        {
            Debug.Log( "In RightClick " ); 
        }

        public void PrintLeft()
        {
            Debug.Log( "In LeftClick" );
        }
    }
}
