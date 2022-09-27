using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class IntroductionAnimationProvider : MonoBehaviour
    {
        private int k_onMouseEnter = Animator.StringToHash( "OnMouseEnter" );

        [SerializeField] private Animator m_animator; 

        private void OnMouseEnter()
        {
            m_animator.SetBool( k_onMouseEnter, true );
        }

        private void OnMouseExit()
        {
            m_animator.SetBool( k_onMouseEnter, false );
        }
    }
}
