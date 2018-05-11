using UnityEngine;
using UnityEngine.UI;

namespace WebGLBuild
{
    /// <summary>
    /// Place on InputField to control properties.
    /// </summary>
    public class InputFieldController : MonoBehaviour
    {
        #region FIELD
        private InputField inputField;
        #endregion

        #region UNITY METHODS
        private void Awake()
        {
            inputField = GetComponent<InputField>();
        }
        private void Start()
        {
            inputField.interactable = false;
        }
        #endregion

        #region METHODS
        public void MakeFieldInteractable()
        {
            inputField.interactable = true;
        }
        public void MakeFieldNotInteractable()
        {
            inputField.interactable = false;
        }
        #endregion
    }
}
