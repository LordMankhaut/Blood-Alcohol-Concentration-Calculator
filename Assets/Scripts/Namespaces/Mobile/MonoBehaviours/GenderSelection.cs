using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace MobileBuild
{
    public class GenderSelection : MonoBehaviour
    {
        #region FIELD
        public List<Button> buttons;
        private int isVisibleHash = Animator.StringToHash("isVisible");
        #endregion
        #region METHODS
        #region Unity
        private void Awake()
        {
            foreach (Button button in GetComponentsInChildren<Button>())
            {
                buttons.Add(button);
            }
        }
        private void Start()
        {
            foreach (Button button in buttons)
            {
                button.interactable = false;
            }
        }
        #endregion
        #region Public
        public void SetButtonInteractability(bool interactable)
        {
            foreach (Button button in buttons)
            {
                Animator animator = button.GetComponent<Animator>();
                animator.SetBool(isVisibleHash, interactable);
            }
        }
        #endregion
        #region Private

        #endregion
        #endregion
    }
}
