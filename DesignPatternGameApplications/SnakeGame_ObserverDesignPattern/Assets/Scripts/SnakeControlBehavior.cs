using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class SnakeControlBehavior : MonoBehaviour
    {
        SnakeCard m_snakeControl;
        ScoreManagement m_scoreManagement;
        private Rigidbody rigidbody;
        float velocity = 5f;

        void Start()
        {
            m_scoreManagement = new ScoreManagement();
            m_snakeControl = new SnakeCard( m_scoreManagement );
            rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            float horizontal = Input.GetAxis( "Horizontal" );
            float vertical = Input.GetAxis( "Vertical" );

            Vector3 vector = new Vector3( horizontal, 0, vertical );

            rigidbody.AddForce( vector * velocity );
        }

        private void OnCollisionEnter( Collision collision )
        {
            GameObject crashedObject = collision.gameObject;

            if( crashedObject.tag == "Obstacle" )
            {
                m_scoreManagement.SetScore( -1 );
            }
            else if( crashedObject.tag == "Food" )
            {
                m_scoreManagement.SetScore( +1 );
            }
            else
            {
                Debug.Log( "Who are you? I dont know you" );
            }
        }
    }
}