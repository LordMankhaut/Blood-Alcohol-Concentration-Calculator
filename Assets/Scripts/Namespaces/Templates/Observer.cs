using UnityEngine;


namespace PatternTemplates
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Observer : MonoBehaviour, IObserver
    {
        #region FIELD
        [SerializeField] protected Subject subject;
        [SerializeField] protected string observerStringState;
        [SerializeField] protected int observerIntegerState;
        #endregion

        #region PROPERTIES
        public abstract Subject Subject { get; set; }
        public virtual int ObserverIntegerState { get; set; }
        public virtual string ObserverStringState { get; set; }
        #endregion

        #region METHODS
        public abstract void SynchronizeSubjectStates();
        public virtual void RefreshDisplayedValues() { }
        #endregion

    }
}

