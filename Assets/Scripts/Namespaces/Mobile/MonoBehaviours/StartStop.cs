using UnityEngine;

namespace MobileBuild
{
    /// <summary>
    ///     //Change the animator parameter on button click.
    /// </summary>
    public class StartStop : MonoBehaviour
    {
        #region FIELD
        public Animator animator;
        private AudioSource audioSource;
        private static int isOnHash = Animator.StringToHash("isOn");
        #endregion

        #region METHOD
        #region Unity
        private void Awake()
        {
            animator = GetComponent<Animator>();
            audioSource = GetComponent<AudioSource>();
        }
        #endregion

        #region Public
        public void StartTimer()
        {
            animator.SetBool(isOnHash, true);
            audioSource.Play();
        }
        public void StopTimer()
        {
            animator.SetBool(isOnHash, false);
            audioSource.Play();
        }
        #endregion
        #endregion
    }
}