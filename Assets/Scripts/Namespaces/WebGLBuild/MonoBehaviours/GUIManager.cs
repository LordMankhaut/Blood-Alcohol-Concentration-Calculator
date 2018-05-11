using UnityEngine;

namespace WebGLBuild
{
    /// <summary>
    /// Place on Canvas and use to control any changes to the GUI.
    /// </summary>
    public class GUIManager : MonoBehaviour
    {
        #region FIELD
        public GUIButtonManager buttonManager;
        public GUIToggleManager toggleManager;
        public GUIInputFieldManager inputFieldManager;
        public GUITextManager textManager;
        public GUIImageManager imageManager;
        public DataManager dataManager;
        public StepNavigationOptions navOptions;
        public CalculatorSceneManager sceneManager;
        #endregion

        #region METHODS
        #region Public    
        //Call at start and when resetting the calculator.  Step returns to Zero and all GUI selections and values are removed.
        public void ResetGUI(StepNavigationOptions options)
        {
            navOptions = options;
            buttonManager.ResetButtons(navOptions);
            toggleManager.ResetAllToggles();
            textManager.ResetAllTexts();
            inputFieldManager.ResetAllFields();
            imageManager.NormalColor();
            dataManager.ResetDefaults();
        }
        public void SetupStep(IStep step)
        {
            //highlight the step
            //imageManager.LookForHighlight(step);
            //make toggles or input fields interactable
        }
        public void GenderChanged(bool isMale)
        {
            Gender.userRatio = (isMale) ? Gender.maleRatio : Gender.femaleRatio;
            textManager.UpdateText(textManager.ratio, Gender.userRatio);

        }
        public void WeightUnitChanged(bool isPounds)
        {
            Weight.weightUnit = (isPounds) ? Weight.weightUnit = WeightUnits.Pound : Weight.weightUnit = WeightUnits.Kilogram;
            sceneManager.RecalculateChangedWeightUnits(Weight.weightUnit);

        }
        public void WeightChanged(float weight)
        {
            Weight.weightInput = Mathf.Round(weight);
            //sceneManager.RecalculateAfterChange();
            textManager.UpdateText(textManager.weight, Weight.weightInput);
        }
        public void VolumeChanged(float volume)
        {
            Alcohol.totalVolume = volume;
            //sceneManager.RecalculateAfterChange();
            textManager.UpdateText(textManager.volume, Alcohol.totalVolume);
        }
        #endregion
        #endregion
    }
}
