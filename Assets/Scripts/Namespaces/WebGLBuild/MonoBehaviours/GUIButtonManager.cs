using UnityEngine;
using UnityEngine.UI;

namespace WebGLBuild
{
    /// <summary>
    /// This class holds references to the Button objects in the scene that will change interactability.
    /// Steps will directly call the methods for each button, passing in a bool indicating desired interactablity state.
    /// </summary>
    public class GUIButtonManager : MonoBehaviour
    {
        #region FIELD
        private StepNavigationOptions options;
        private GUIManager guiManager;
        private CalculatorSceneManager sceneManager;
        //These buttons will need to be occasionally made non-interactable or interactable depending on the current step and state of step (Complete or not completed).
        public Button
            next,
            previous,
            reset,
            go,
            help;
        #endregion

        #region METHODS
        #region Unity
        private void Awake()
        {
            guiManager = FindObjectOfType<GUIManager>();
            sceneManager = FindObjectOfType<CalculatorSceneManager>();
        }
        #endregion

        #region Public
        public void ResetButtons(StepNavigationOptions options)
        {
            ChangeNextButton(options.canGoToNext);
            ChangePreviousButton(options.canGoToPrevious);
            ChangeResetButton(options.canReset);
            ChangeGoButton(options.canGo);
        }
        //Steps call these methods to activate and desactivate buttons passing in a bool that indicates its desired interactablity.
        private void ChangeNextButton(bool active)
        {
            ChangeButtonState(next, active);

        }
        private void ChangePreviousButton(bool active)
        {
            ChangeButtonState(previous, active);

        }
        private void ChangeResetButton(bool active)
        {
            ChangeButtonState(reset, active);

        }
        private void ChangeGoButton(bool active)
        {
            ChangeButtonState(go, active);

        }
        public void ResetClicked()
        {
            sceneManager.ResetCalculator();

        }
        public void Help()
        {
            Debug.Log("GUIButtonManager.Help() not yet developed.");
        }
        public void GoToNextStep()
        {
            sceneManager.NextStepRequested();
        }
        public void GoToPreviousStep()
        {
            sceneManager.PreviousStepRequested();
        }
        #endregion

        #region Private
        private void ChangeButtonState(Button button, bool active)
        {
            if (active) { button.interactable = true; }
            else { button.interactable = false; }

        }
        #endregion
        #endregion
    }
}
