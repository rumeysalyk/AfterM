using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeCard : IScoreObserver
{
    public ScoreManagement m_scoreManagement;
    private int m_score;
    public SnakeCard( ScoreManagement a_scoreManagement )
    {
        m_scoreManagement = a_scoreManagement;
        m_scoreManagement.RegisterObserver( this );
    }

    public void update( int score )
    {
        m_score = score;
    }

}
