using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    Vector2 m_direction = Vector2.right;

    private void Update()
    {
        if( Input.GetKeyDown( KeyCode.W ) )
        {
            m_direction = Vector2.up;
        }
        else if( Input.GetKeyDown( KeyCode.S) )
        {
            m_direction = Vector2.down;
        }
        else if( Input.GetKeyDown( KeyCode.A ) )
        {
            m_direction = Vector2.left;
        }
        else if( Input.GetKeyDown( KeyCode.D ) )
        {
            m_direction = Vector2.right;
        }
    }

    private void FixedUpdate()
    {
        this.transform.position = new Vector3( Mathf.Round( this.transform.position.x + m_direction.x),
                                               Mathf.Round( this.transform.position.y + m_direction.y),
                                               0.0f );
    }
}
