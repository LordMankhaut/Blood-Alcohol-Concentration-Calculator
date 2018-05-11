using System.Collections;

namespace MobileBuild
{
    /// <summary>
    ///     //First scene on start of program.
    ///     //1.Handle notebook messages being displayed.
    ///     //2.Hold references to faders for scene exit. The parameter must be changed to get the animator to change state.
    ///     //3.Handle click of start button.
    ///     //4.Repost the program has been started to MainControl.
    ///     //5.Knows about fading scripts and directs animation.
    ///     
    /// </summary>
    public class SceneZero : SceneController
    {
        #region FIELD         
        public OpenSign sign;        
        public StartStop button;        
        #endregion

        #region PROPERTIES
        public string NormalMessage { get { return "This is normal message."; } }
        public string HelpMessage { get { return "This is the help message."; } }
        public override string CurrentMessage { get; set; }
        #endregion

        #region METHODS        
        #region Unity        
        private void Start()
        {            
            Begin();
        }
        #endregion

        #region Public        
        public void TurnOn()
        {            
            StartCoroutine(TurnOnSequence());                                  
        }
        #endregion

        #region Protected        
        protected override void Begin()
        {
            CurrentMessage = NormalMessage;
            notebook.UpdateMessage();
        }          
        #endregion

        #region Private
        private IEnumerator TurnOnSequence()
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