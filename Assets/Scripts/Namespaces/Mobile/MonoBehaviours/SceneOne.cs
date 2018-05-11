using System.Collections;

namespace MobileBuild
{
    /// <summary>
    ///     //Step One:
    ///     //1. When application is turned off, this is an alternate start scene.
    ///     //2. Still contains and displays data entered,
    ///     //3. Ask the user if they want to continue.  (in case of accidentally turning off, time continues from before)
    ///     //4. Wait for button press, animate, fade, and change to scene 2.
    /// </summary>
    public class SceneOne : SceneController
    {
        #region FIELD        
        //Reference the scene specific components.                
        public OpenSign sign;   
        public StartStop button;     
        #endregion

        #region PROPERTIES
        private string Message11 { get { return Dialogue.message11; } }
        
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
        public IEnumerator TurnOnSequence()
        {            
            FadeOut(smallFader);
            //Play audio clip.            
            Collect();            
            yield return waitForSecond;             
            ChangeToScene("MobileScene02");   
        }
        #endregion

        #region Protected
        protected override void Begin()
        {            
            UpdateNotebook();            
        }
        protected override void UpdateNotebook()
        {
            notebook.leftPage.text = Message11;            
        }
        #endregion        
        #endregion
    }
}