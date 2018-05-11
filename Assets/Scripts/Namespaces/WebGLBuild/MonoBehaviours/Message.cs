using UnityEngine;
using UnityEngine.UI;

namespace WebGLBuild
{
    /// <summary>
    /// Attach to the game object with a Text component.
    /// </summary>
    [RequireComponent(typeof(Text))]
    public class Message : MonoBehaviour
    {
        #region FIELD
        private static Text messageText;
        #endregion

        #region PROPERTIES
        public static Text MessageText
        {
            get { return messageText; }
        }
        #endregion

        #region METHODS

        #region Unity
        private void Awake()
        {
            messageText = GetComponent<Text>();

        }
        #endregion

        #region Public
        public static void UpdateMessage(string message)
        {
            //print("Message.UpdateMessage(string message)");
            messageText.text = message;

        }
        #endregion

        #endregion
    }
}
