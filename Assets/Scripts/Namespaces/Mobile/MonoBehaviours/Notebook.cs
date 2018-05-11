using UnityEngine;
using UnityEngine.UI;

namespace MobileBuild
{
    /// <summary>
    /// 
    /// </summary>
    public class Notebook : MonoBehaviour
    {
        #region FIELD
        public Text rightPage;
        public Text leftPage;
        public SceneController sceneController;
        private string currentMessage;
        private string timeString;
        private string left;
        private string right;
        #endregion

        #region PROPERTIES
        public SceneController SceneController { get; set; }
        #endregion

        #region METHODS
        public void UpdateMessage()
        {
            currentMessage = sceneController.CurrentMessage;
            UpdateLeftPage(currentMessage);
        }
        public void UpdateLeftPage(string text)
        {
            leftPage.text = text;
        }
        public void UpdateRightPage(string text)
        {
            rightPage.text = text;
        }
        private string BuildTimeString()
        {
            int hours = Time.startTime.Hour;
            int minutes = Time.startTime.Minute;
            string time = hours.ToString().PadLeft(2, '0') +
                " :" +
                minutes.ToString().PadLeft(2, '0');
            return time;
        }
        public void Message() { }
        #endregion
    }
}