using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Singleton structure
public class ObserverManager : MonoBehaviour
{
    #region Singleton

    private static ObserverManager m_instance = null;
    public static ObserverManager Instance => m_instance;

    #endregion

    private List<Subject> m_subjects = null;
    private void Awake()
    {
        m_instance = this;
    }

    private void Start()
    {
        IntEvent intEvent = new IntEvent
        {
            AnyInt = 5
        };

        EventManager.Instance.Propagte(intEvent);
    }

    public void RegisterSubject( Subject a_subject )
    {
        if (m_subjects is null)
            m_subjects = new List<Subject>();
        m_subjects.Add( a_subject );
    }

    public void RegisterObserver( Observer a_observer, SubjectType a_subjectType)
    {
        foreach (var subject in m_subjects)
        {
            if( subject.SubjectType == a_subjectType )
            {
                subject.RegisterObserver( a_observer );
            }
        }
    }


}

public enum NotificationType
{
    ForwardButton,
    BackButton,
    LeftButton,
    RightButton
}

public enum SubjectType
{
    MovementPanel
}