using System;
using UnityEngine;

namespace MobileBuild
{
    /// <summary>
    /// Subjects are objects that are observed for changes to one or more states.
    /// The observer is notified of the change.
    /// The observer then updates its local state to match.
    /// </summary>
    public abstract class Subject : MonoBehaviour, ISubject
    {
        #region FIELD
        [SerializeField] protected Observer[] observers;
        [SerializeField] protected string subjectStringState;        
        #endregion

        #region PROPERTIES
        public abstract Observer[] Observers { get; set; }
        public virtual bool SubjectBoolState { get; set; }
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
                Observers[i].Synchronize();
            }
        }
        #endregion
    }
}
