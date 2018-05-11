using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace WebGLBuild
{
    /// <summary>
    /// 
    /// </summary>
    public class GUITextManager : MonoBehaviour
    {
        #region FIELD
        public Text
            message,
            ratio,
            weight,
            weightInGrams,
            numDrinks,
            volume,
            percent,
            doseInGrams,
            rawBAC,
            time,
            BAC;
        //public const string defaultMessageText = Dialogue.stepZeroMessage;
        public const string defaultEmptyText = "";
        public List<Text> allTexts = new List<Text>();
        #endregion

        #region METHODS
        private void Start()
        {
            allTexts.Add(ratio);
            allTexts.Add(weight);
            allTexts.Add(weightInGrams);
            allTexts.Add(numDrinks);
            allTexts.Add(volume);
            allTexts.Add(percent);
            allTexts.Add(doseInGrams);
            allTexts.Add(rawBAC);
            allTexts.Add(time);
            allTexts.Add(BAC);
        }
        public void UpdateText(Text text, string str)
        {
            text.text = str;

        }
        public void UpdateText(Text text, float f)
        {
            string str = f.ToString();
            UpdateText(text, str);

        }
        public void UpdateText(Text text, int i)
        {
            string str = i.ToString();
            UpdateText(text, str);

        }
        public void ResetAllTexts()
        {
            //message.text = defaultMessageText;
            foreach (var text in allTexts)
            {
                text.text = defaultEmptyText;
            }
        }
        #endregion
    }
}
