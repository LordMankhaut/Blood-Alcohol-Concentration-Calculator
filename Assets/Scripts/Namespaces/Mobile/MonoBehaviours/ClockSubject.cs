using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

namespace MobileBuild
{
    /// <summary>
    /// Attached to Clock.
    /// Get real world time and updates it every second.
    /// </summary>
    public class ClockSubject : Subject
    {
        #region FIELD
        private DateTime current = new DateTime();
        private int
            hours,
            minutes;
        private float delay = 1f;
        #endregion

        #region PROPERTIES
        public override Observer[] Observers { get { return observers; } set { observers = value; } }
        public override string SubjectStringState { get { return subjectStringState; } set { subjectStringState = value; } }
        #endregion

        #region METHODS
        #region Unity        
        private void Start()
        {
            Notify();
            InvokeRepeating("UpdateClock", 0f, delay);
        }
        #endregion
        #region Private
        private void UpdateClock()
        {            
            if (current.Minute != DateTime.Now.Minute)
            {
                current = DateTime.Now;
                SubjectStringState = BuildTimeString();
                Notify();
            }            
        }
        private string BuildTimeString()
        {
            hours = current.Hour;
            minutes = current.Minute;
            SubjectStringState = hours.ToString().PadLeft(2, '0') +
                minutes.ToString().PadLeft(2, '0');
            return SubjectStringState;
        }              
        #endregion
        #endregion
    }
}
