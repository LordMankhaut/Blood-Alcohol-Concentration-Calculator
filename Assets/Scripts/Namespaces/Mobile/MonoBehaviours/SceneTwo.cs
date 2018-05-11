using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace MobileBuild
{
    /// <summary>
    ///     //SceneTwo: Input custom time or save current time.
    ///     //1. Fade in the small fader panel.
    ///     //2. Turn on the Open sign.
    ///     //3. Update Notebook text.
    ///     //4. Ask if user wants custom time or use current time.
    /// </summary>
    public class SceneTwo : SceneController
    {
        #region FIELD         
        public OpenSign sign;
        public Toggle setCustomTime;
        public Button subtract60Minutes;
        public Button subtract15Minutes;
        public Button reset;
        private bool isCustomTime;
        public Text hour;
        public Text minute;
        public Text notebookHour;
        public Text notebookMinute;
        public Text notebookTotalHours;
        public Text notebookModifier;
        private int startMinutes;
        private int startHours;
        private float modifier;
        private TimeSpan timeSpan;
        private const int fifteen = 15;
        private const int sixty = 60;
        private const float multiplier = 0.015f;
        private DateTime startTime = new DateTime();
        
        #endregion

        #region PROPERTIES
        private string Message21 { get { return Dialogue.message21; } } 
        
        public int StartMinutes { get { return startMinutes; } set { startMinutes = value; } }
        public int StartHours { get { return startHours; } set { startHours = value; } }
        #endregion

        #region METHODS

        #region Unity        
        private void Start()
        {
            Begin();    
        }
        #endregion

        #region Public        
        public void Off()
        {
            StartCoroutine(TurnOffSequence());            
        }
        public void MakeButtonsInteractable()
        {
            subtract15Minutes.interactable = setCustomTime.isOn;
            subtract60Minutes.interactable = setCustomTime.isOn;
            reset.interactable = setCustomTime.isOn;
        }
        public void Subtract15Minutes()
        {
            if (StartMinutes >= fifteen)
            {
                StartMinutes -= fifteen;
            }
            else
            {
                Subtract60Minutes();
                StartMinutes += sixty;
                StartMinutes -= fifteen;
            }
            minute.text = StartMinutes.ToString().PadLeft(2, '0');
            notebookMinute.text = StartMinutes.ToString().PadLeft(2, '0');
            startTime = startTime.AddMinutes(-15);
            GetHoursSinceStart();
            GetTimeModifier();
        }
        public void Subtract60Minutes()
        {
            if (StartHours != 0)
            {
                StartHours--;
            }
            else
            {
                StartHours = 23;
            }
            hour.text = StartHours.ToString().PadLeft(2, '0');
            notebookHour.text = StartHours.ToString().PadLeft(2, '0');
            startTime = startTime.AddHours(-1);
            GetHoursSinceStart();
            GetTimeModifier();
        }
        public void SaveStartTime()
        {
            MainController.userStartHour = StartHours;
            MainController.userStartMinute = StartMinutes;
            
            StartCoroutine(GoToNextSceneSequence());
        }
        public void ResetStartTime()
        {
            UpdateStartTime();
            GetHoursSinceStart();
            GetTimeModifier();
        }
        #endregion

        #region Protected
        protected override void Begin()
        {            
            UpdateNotebook();
            UpdateStartTime();
        }        
        protected override void UpdateNotebook()
        {
            notebook.leftPage.text = Message21;            
        }
        #endregion

        #region Private
        private IEnumerator TurnOffSequence()
        {
            FadeOut(smallFader);
            //Play audio clip.
            Collect();
            yield return waitForSecond;
            ChangeToScene("MobileScene01");
        }
        private IEnumerator GoToNextSceneSequence()
        {
            FadeOut(smallFader);
            //Play audio clip.
            Collect();
            yield return waitForSecond;
            ChangeToScene("MobileScene03");
        }
        private void UpdateStartTime()
        {
            StartHours = DateTime.Now.Hour;
            StartMinutes = DateTime.Now.Minute;
            startTime = DateTime.Now;
            GetTimeModifier();
            hour.text = StartHours.ToString().PadLeft(2, '0');
            minute.text = StartMinutes.ToString().PadLeft(2, '0');
            notebookHour.text = StartHours.ToString().PadLeft(2, '0');
            notebookMinute.text = StartMinutes.ToString().PadLeft(2, '0');
        }
        private void GetHoursSinceStart()
        {
            timeSpan = DateTime.Now - startTime;
            notebookTotalHours.text = timeSpan.TotalHours.ToString("0.00");
        }
        private void GetTimeModifier()
        {
            modifier = (float)timeSpan.TotalHours * multiplier;
            notebookModifier.text = modifier.ToString("0.00");
        }
        #endregion
        #endregion
    }
}