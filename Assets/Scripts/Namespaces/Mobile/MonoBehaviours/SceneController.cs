using System;
using System.Collections;
using UnityEngine;

namespace MobileBuild
{
    /// <summary>
    ///     //1.Base class for all scene controllers.
    ///     //2.Defines common methods for each derived class.
    ///     //3.Establishes references used by all derived classes.
    /// </summary>
    public class SceneController : MonoBehaviour
    {
        #region FIELD          
        public WaitForSeconds 
            waitForSecond = new WaitForSeconds(1f),        
            waitFor15Seconds = new WaitForSeconds(15f);        
        public Notebook notebook;        
        protected delegate void ChangeScene(string s);        
        protected ChangeScene ChangeToScene = new ChangeScene(MainController.ChangeScene);
        public DarkFader 
            smallFader,
            largeFader;
        #endregion
        #region PROPERTIES
        public virtual string CurrentMessage { get; set; }
        #endregion
        #region METHODS 
        #region Protected
        protected void Collect()
        {
            GC.Collect();
        }
        protected void FadeOut(DarkFader fader)
        {
            fader.FadeOut();
        }        
        protected virtual void Begin() { }
        protected virtual void UpdateNotebook() { }
        protected IEnumerator TurnOnSequence(DarkFader fader, string scene)
        {
            FadeOut(smallFader);
            //Play audio.            
            Collect();
            yield return waitForSecond;
            ChangeToScene("MobileScene02");
        }
        #endregion
        #endregion
    }
}