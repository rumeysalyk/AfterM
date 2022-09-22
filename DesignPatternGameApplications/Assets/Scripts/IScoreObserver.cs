using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public interface IScoreObserver
    {
        public void update( int score );
    }
}