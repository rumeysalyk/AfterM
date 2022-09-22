using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    //subject class for observer design pattern 
    public interface IScoreManagement 
    {
        public void RegisterObserver( IScoreObserver observer );
        public void RemoveObserver( IScoreObserver observer );
        public void NotifyObservers();

    }
}