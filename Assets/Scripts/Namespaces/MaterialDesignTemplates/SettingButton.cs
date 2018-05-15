using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaterialDesignTemplates
{
    class SettingButton
    {
        public TitleText titleText;

        public void OnClick()
        {
            GoToSettingState();
        }

        private void GoToSettingState()
        {
            titleText.screenState = ScreenStates.Settings;
            titleText.OnStateChange();
        }

    }
}
