using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class ScoreManagement : IScoreManagement
    {
        private List<IScoreObserver> m_observers;
        int m_score = 0;


        public void NotifyObservers()
        {
            foreach( var observer in m_observers )
            {
                observer.update( m_score );
            }
        }

        public void RegisterObserver(IScoreObserver observer)
        {
            m_observers.Add( observer );
        }

        public void RemoveObserver(IScoreObserver observer)
        {
            m_observers.Remove( observer );
        }

        public void SetScore( int a_score )
        {
            m_score += a_score;
            NotifyObservers();
        }
    }
}