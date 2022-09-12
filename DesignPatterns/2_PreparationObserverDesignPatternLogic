using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject : MonoBehaviour
{
    private List<Observer> _observers = null;
    [SerializeField] private SubjectType m_subjectType;
    public SubjectType SubjectType => m_subjectType;
    public void RegisterObserver( Observer a_observer )
    {
        if (_observers is null)
            _observers = new List<Observer>();

        _observers.Add(a_observer);
    }

    public void Start()
    {
        //Subject oluşturulduğu anda onu ObserverManagere kayıt ediyoruz
        ObserverManager.Instance.RegisterSubject(this);
    }

    public void Notify( NotificationType a_notificationType )
    {
        foreach (var observer in _observers)
        {
            observer.OnNotify(a_notificationType);
        }
    }
}
