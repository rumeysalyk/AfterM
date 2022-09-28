using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts
{
    public class IntroductionAnimationModule : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
    {
        private int k_onMouseEnter = Animator.StringToHash( "OnMouseEnter" );

        [SerializeField] private Animator m_animator;

        public void OnPointerEnter( PointerEventData eventData )
        {
            m_animator.SetBool( k_onMouseEnter, true );
            Debug.Log( "Deneme1" );
        }

        public void OnPointerExit( PointerEventData eventData )
        {
            m_animator.SetBool( k_onMouseEnter, false );
            Debug.Log( "Deneme2" );
        }
    }
}
