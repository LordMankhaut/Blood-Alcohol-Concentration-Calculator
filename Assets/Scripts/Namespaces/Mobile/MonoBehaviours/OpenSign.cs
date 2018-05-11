using UnityEngine;
using UnityEngine.UI;

namespace MobileBuild
{
    public class OpenSign : MonoBehaviour
    {
        #region FIELD
        public Image image;
        public Animator animator;
        public AudioSource audioSource;
        private static int isOnHash = Animator.StringToHash("isOn");
        #endregion

        #region METHODS
        #region Unity
        private void Awake()
        {
            image = GetComponentInChildren<Image>();
            animator = GetComponentInChildren<Animator>();
            audioSource = GetComponentInChildren<AudioSource>();
        }        
        #endregion
        #region Public
        public void TurnOn()
        {
            animator.SetBool(isOnHash, true);
            audioSource.Play();
        }
        public void TurnOff()
        {
            animator.SetBool(isOnHash, false);
            audioSource.Play();
        }          
        #endregion        
        #endregion
    }
}