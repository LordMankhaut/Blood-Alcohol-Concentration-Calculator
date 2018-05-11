using System;
using UnityEngine;

namespace PatternTemplates
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Subject : MonoBehaviour, ISubject
    {
        #region FIELD
        [SerializeField] protected Observer[] observers;
        [SerializeField] protected string subjectStringState;
        [SerializeField] protected int subjectIntegerState;
        #endregion

        #region PROPERTIES
        public abstract Observer[] Observers { get; set; }
        public virtual string SubjectStringState { get; set; }
        public virtual int SubjectIntegerState { get; set; }
        #endregion

        #region METHODS
        public void Attach(Observer observer)
        {
            int index = Observers.Length - 1;
            Observers[index] = observer;
        }
        public void Detach(Observer observer)
        {
            for (int i = 0; i < Observers.Length; i++)
            {
                if (Observers[i].Equals(observer))
                {
                    Array.Clear(Observers, i, 1);
                    Array.Sort(Observers);
                }
            }
        }
        public void Notify()
        {
            for (int i = 0; i < Observers.Length; i++)
            {
                Observers[i].SynchronizeSubjectStates();
            }
        }
        #endregion
    }
}
