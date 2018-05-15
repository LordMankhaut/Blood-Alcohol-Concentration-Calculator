using System;
using UnityEngine;
using UnityEngine.UI;

namespace MaterialDesignTemplates
{
    class TitleText : MonoBehaviour
    {
        Text title;

        Fader fader;

        public ScreenStates screenState;

        public TitleTextState currentTitle;

        public float 
            alphaIn = 1,
            alphaOut = 0f;

        private void Awake()
        {
            currentTitle = new MainTitleText();
            title = GetComponent<Text>();
            ChangeTitle();
        }

        public void ChangeTitle()
        {
            title.text = currentTitle.Title;
        }

        private void UpdateCurrentState()
        {
            switch (screenState)
            {
                case ScreenStates.Main:
                    {
                        currentTitle = new MainTitleText();
                        break;
                    }
                case ScreenStates.Settings:
                    {
                        currentTitle = new SettingTitleText();
                        break;
                    }
                default:
                    {
                        throw new SystemException("The current state does not match any of the options when trying to update.");                        
                    }
            }
        }

        public void OnStateChange()
        {
            UpdateCurrentState();
            ChangeTitle();
        }
    }
}
