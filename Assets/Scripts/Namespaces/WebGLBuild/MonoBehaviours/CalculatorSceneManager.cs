using UnityEngine;

namespace WebGLBuild
{
    /// <summary>
    /// 
    /// </summary>
    public class CalculatorSceneManager : MonoBehaviour
    {
        #region FIELD
        public StepManager stepManager;
        public GUIManager guiManager;
        public DataManager dataManager;
        public StepNavigationOptions options;
        #endregion

        #region METHODS
        #region Unity  
        private void Start()
        {
            stepManager.ResetSteps();
            guiManager.ResetGUI(stepManager.options);   //passing in current step since it should be StepZero and I want the button interactability.
        }
        #endregion

        #region Public
        public void ResetCalculator()
        {
            stepManager.ResetSteps();
            guiManager.ResetGUI(stepManager.options);
            //Calculation reset
            //data reset
            //gui resset

        }
        public void NextStepRequested()
        {
            stepManager.SwitchToNextStep();
            options = stepManager.options;
            //guiManager.SetupStep(stepmanager.currentStep);

        }
        public void PreviousStepRequested()
        {
            stepManager.SwitchToPreviousStep();
            options = stepManager.options;
            //guiManager.SetupStep(stepmanager.currentStep);

        }
        public void RecalculateChangedWeightUnits(WeightUnits units)
        {
            if (Weight.weightInput != 0)
            {
                if (units == WeightUnits.Pound && Weight.weightUnit == WeightUnits.Kilogram)
                {
                    Weight.weightInput = Conversions.ConvertKilosToPounds(Weight.weightInput);
                    guiManager.textManager.UpdateText(guiManager.textManager.weight, Weight.weightInput);

                }
            }
            else
            {
                guiManager.textManager.UpdateText(guiManager.textManager.weight, Weight.weightInput);

            }
        }
        #endregion
    }

    #region Calculator

    #region Commented Out
    //private void ResetCalculator()
    //{

    //}
    //public void CallPreviousStep()
    //{
    //    //StepManager.CurrentStep.PreviousStep();
    //}
    //public void CallNextStep()
    //{
    //    //StepManager.CurrentStep.NextStep();
    //    //guiButtonManager.ChangeButtonInteractable(StepManager.CurrentStep);
    //    //guiManager.GUIButtonManager.ChangeButtonInteractable(StepManager.CurrentStep);
    //}
    ////When toggle boxes are selected.     
    ////public void UpdateWeight(bool isPounds)
    ////{
    ////    //RefreshInstructions();
    ////    //depending on which toggle selected, set currentWeightUnit
    ////    //if current weight is the same
    ////    if ((isPounds && Weight.weightUnit == WeightUnits.Pound) || (!isPounds && Weight.weightUnit == WeightUnits.Kilogram))
    ////        //do nothing
    ////        return;
    ////    //else switch weight unit
    ////    else if (isPounds && Weight.weightUnit == WeightUnits.Kilogram)
    ////    {
    ////        Weight.weightUnit = WeightUnits.Pound;
    ////        //convert current weight value to new unit
    ////        Weight.userInputWeight = Calculator.ConvertKilosToPounds(Weight.userInputWeight);
    ////    }
    ////    else if (!isPounds && Weight.weightUnit == WeightUnits.Pound)
    ////    {
    ////        Weight.weightUnit = WeightUnits.Kilogram;
    ////        //convert current weight value to new unit
    ////        Weight.userInputWeight = Calculator.ConvertPoundsToGrams(Weight.userInputWeight);
    ////    }
    ////    //refresh displayed value
    ////    RefreshWeight();
    ////}    
    ////public void UpdateVolume(bool isOunces)
    ////{
    ////    //depending on which toggle selected, set currentVolumeUnit
    ////    //if current volume is the same
    ////    if ((isOunces && Alcohol.volumeUnit == VolumeUnits.Ounces) || (!isOunces && Alcohol.volumeUnit == VolumeUnits.Liters))
    ////        //do nothing
    ////        return;
    ////    //else switch volume unit
    ////    else if (isOunces && Alcohol.volumeUnit == VolumeUnits.Liters)
    ////    {
    ////        Alcohol.volumeUnit = VolumeUnits.Ounces;
    ////        //convert current volume value to new unit
    ////        Alcohol.userInputVolume = Calculator.ConvertMillilitersToOunces(Calculator.ConvertLitersToMilliliters(Alcohol.userInputVolume));
    ////    }
    ////    else if (!isOunces && Alcohol.volumeUnit == VolumeUnits.Ounces)
    ////    {
    ////        Alcohol.volumeUnit = VolumeUnits.Liters;
    ////        //convert current volume value to new unit
    ////        Alcohol.userInputVolume = Calculator.ConvertOuncesToMilliliters(Calculator.ConvertMillilitersToLiters(Alcohol.userInputVolume));
    ////    }
    ////    //refresh displayed value
    ////    RefreshVolume();
    ////}
    ////public void UpdatePercent(int typeIndex)
    ////{
    ////    switch (typeIndex)
    ////    {
    ////        case (int)DrinkTypes.Beer :
    ////            {
    ////                Alcohol.percentAlcohol = Alcohol.defaultBeerPercent;
    ////                break;
    ////            }
    ////        case (int)DrinkTypes.Wine:
    ////            {
    ////                Alcohol.percentAlcohol = Alcohol.defaultWinePercent;
    ////                break;
    ////            }
    ////        case (int)DrinkTypes.Distilled:
    ////            {
    ////                Alcohol.percentAlcohol = Alcohol.defaultDistilledPercent;
    ////                break;
    ////            }
    ////    }
    ////    RefreshPercent();
    ////}    
    ////When user has pressed enter to finish editing.
    ////public void ChangeWeight(string weight)
    ////{
    ////    Weight.userInputWeight = float.Parse(weight);
    ////    RefreshWeight();
    ////    ClearTextField(weightInput);
    ////}
    ////public void ChangeVolume(string volume)
    ////{
    ////    Alcohol.userInputVolume = float.Parse(volume);
    ////    RefreshVolume();
    ////    ClearTextField(volumeInput);
    ////}
    ////public void ChangePercent(string percent)
    ////{

    ////    Alcohol.percentAlcohol = float.Parse(percent)/100;
    ////    RefreshPercent();
    ////    ClearTextField(percentInput);
    ////}
    ////public void ChangeHours(string hours)
    ////{
    ////    Time.userInputHours = float.Parse(hours);
    ////    RefreshHours();
    ////    ClearTextField(hoursInput);
    ////}
    ////When displayed amount needs to be updated.    
    ////private void RefreshWeight()
    ////{        
    ////    //RefreshInstructions();
    ////    userWeight.text = Weight.userInputWeight.ToString("0.0");
    ////}
    ////private void RefreshVolume()
    ////{
    ////    consumedVolume.text = Alcohol.userInputVolume.ToString("0.0");        
    ////}
    ////private void RefreshPercent()
    ////{
    ////    percentInput.text = Alcohol.percentAlcohol.ToString("0.0%");
    ////}
    ////private void RefreshHours()
    ////{        
    ////    hoursModifier.text = Time.userInputHours.ToString("0.00");
    ////    ClearTextField(hoursInput);
    ////}
    ////private void RefreshConcentration()
    ////{
    ////    result.text = concentration.ToString("0.000");
    ////}  
    #endregion

    #endregion
    #region Commented Out
    ////Housekeeping
    //private void ClearTextField(InputField input)
    //{
    //    input.text = "";
    //}    
    //private void ProgressInstruction(int index)
    //{
    //    Dialogue.instructionIndex = index;
    //    //RefreshInstructions();
    //}
    //#region Highlighting Control
    //private void NormalizeGroup(ToggleGroup group)
    //{
    //    Highlighter highlighter = group.GetComponent<Highlighter>();

    //    highlighter.ChangeHighlightedState(false);
    //}
    //private void HighlightGroup(ToggleGroup group)
    //{
    //    Highlighter highlighter = group.GetComponent<Highlighter>();

    //    highlighter.ChangeHighlightedState(true);
    //}


    //#endregion
    //public void ExitGame()
    //{
    //    Application.Quit();
    //}
    //public void ResetScene()
    //{
    //    print("Feature ResetScene() not yet developed.");
    //}
    ////Calculate the BAC
    ////public void CalculateBAC(out float concentration)
    ////{
    ////    concentration = 100 * (Alcohol.doseInGrams / Weight.rawWeight) - Time.modifier;
    ////    RefreshConcentration();
    ////}
    #endregion
    #endregion
}
