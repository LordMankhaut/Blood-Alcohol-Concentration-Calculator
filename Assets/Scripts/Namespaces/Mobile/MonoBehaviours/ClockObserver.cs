using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// When the clock has a change in the time, the Notify() is called, synchronizing and updating the text field.
/// </summary>
namespace MobileBuild
{
    public class ClockObserver : Observer
    {
        #region FIELD
        [SerializeField] private Text time;
        #endregion

        #region PROPERTIES
        public override Subject Subject { get { return subject; } set { subject = value; } }
        public override string ObserverStringState { get { return observerStringState; } set { observerStringState = value; } }
        #endregion

        #region METHODS
        #region Unity
        private void Awake()
        {
            //ClockSubject must be in the parent game object.  Observer is attached to child text object.
            Subject = GetComponentInParent<ClockSubject>();
            Subject.Attach(this);
            time = GetComponent<Text>();
        }        
        #endregion
        #region Public
        public override void Synchronize()
        {
            ObserverStringState = Subject.SubjectStringState;
            RefreshDisplayedValues();
        }
        public override void RefreshDisplayedValues()
        {
            time.text = ObserverStringState;
        }
        #endregion
        #endregion
    }
}