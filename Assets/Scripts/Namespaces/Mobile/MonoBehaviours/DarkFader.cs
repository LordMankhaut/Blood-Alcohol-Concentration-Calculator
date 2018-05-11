using UnityEngine;

namespace MobileBuild
{
    /// <summary>
    /// Covers the visible area with a black screen, then fades it back out again.  For transitions.
    /// </summary>
    public class DarkFader : MonoBehaviour
    {
        #region FIELD    
        private static string fadedOutHash = "fadedOut";
        public Animator animator;
        #endregion

        #region METHODS        
        #region Unity
        private void Awake()
        {
            animator = GetComponent<Animator>();
        }
        #endregion        

        #region Public        
        public void FadeOut()
        {
            Fade(true);
        }        
        public void FadeIn()
        {
            Fade(false);
        }        
        #endregion

        #region Private        
        private void Fade(bool fadedOut)
        {
            animator.SetBool(fadedOutHash, fadedOut);
        }
        #endregion
        #endregion
    }
}