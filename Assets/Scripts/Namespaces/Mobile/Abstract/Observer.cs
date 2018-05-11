using UnityEngine;


namespace MobileBuild
{
    /// <summary>
    /// Observer is and object that waits for notification from one or more subjects.
    /// It then updates its local states to match the subjects.
    /// </summary>
    public abstract class Observer : MonoBehaviour, IObserver
    {
        #region FIELD
        [SerializeField] protected Subject subject;
        protected string observerStringState;
        protected int observerIntState;
        protected bool observerBoolState;
        #endregion

        #region PROPERTIES
        public abstract Subject Subject { get; set; }
        public virtual int ObserverIntegerState { get; set; }
        public virtual string ObserverStringState { get; set; }
        public virtual bool ObserverBoolState { get; set; }
        #endregion

        #region METHODS
        public abstract void Synchronize();
        public virtual void RefreshDisplayedValues() { }
        #endregion

    }
}

