using System;
using UnityEngine;
using UnityEngine.UI;

namespace WebGLBuild
{
    public class StepOne : Step
    {
        #region FIELD 

        private new IStep nextStep;
        private new IStep previousStep;
        private const EScenes stepNumber = EScenes.SceneOne;

        #endregion

        #region PROPERTIES 

        public override IStep NextStep { get { return nextStep; } }
        public override IStep PreviousStep { get { return previousStep; } }
        public override bool IsComplete { get { return isComplete; } set { value = isComplete; } }
        public override EScenes StepNumber { get { return stepNumber; } }

        #endregion

        #region METHODS

        #region Unity

        private void Start()
        {
            isComplete = false;
            canReset = false;
            canGoToNext = false;

            nextStep = stepManager.StepTwo;
            previousStep = stepManager.StepZero;

        }

        #endregion

        #region Public

        public override void Begin()
        {
            foreach (var toggle in toggleManager.gender)
            {
                toggleManager.ChangeToggleInteractability(toggle, true);
            }

            imageManager.gender.ChangeHighlightedState(true);
            //textManager.message.text = Dialogue.stepOneMessage;

        }

        public override void Return()
        {
            throw new NotImplementedException();

        }

        public override void Leave()
        {
            foreach (var toggle in toggleManager.gender)
            {
                toggleManager.ChangeToggleInteractability(toggle, false);
            }

            imageManager.gender.ChangeHighlightedState(false);
        }

        #endregion

        //public void GenderSelected(bool isMale)
        //{
        //    if (isMale)
        //    {
        //        Gender.isMale = true;   //Not sure if I need a globally available bool for this...
        //        Gender.userRatio = Gender.maleRatio;            
        //    }
        //    else
        //    {
        //        Gender.isMale = false;
        //        Gender.userRatio = Gender.femaleRatio;            
        //    }
        //    RefreshRatio(Gender.userRatio); //Display the value in the GUI.
        //    //ToggleInteractableState(maleToggle, femaleToggle);
        //}
        //public void SetButtonInteractable()
        //{
        //    if (IsComplete)
        //    {
        //        resetButtonInteractable = true;
        //        nextButtonInteractable = true;
        //        previousButtonInteractable = true;
        //    }
        //    else
        //    {
        //        resetButtonInteractable = false;
        //        nextButtonInteractable = false;
        //        previousButtonInteractable = true;
        //    }
        //}
        //public override void PreviousStep()
        //{
        //    LeaveStep();    //Deactivate and un highlight the step.
        //    //StepManager.CurrentStep = StepManager.Steps[0]; //Change CurrentStep to StepZero.
        //    //StepManager.CurrentStep.SwitchStep(StepManager.CurrentStep.IsComplete); //Call the SwitchStep() method on StepZero.

        //}
        //public override void NextStep()
        //{
        //    //StepManager.CurrentStep = StepManager.Steps[2]; //Change the current step to StepTwo.
        //    //StepManager.CurrentStep.SwitchStep(StepManager.CurrentStep.IsComplete);    //Call SwitchStep() on StepTwo, passing in itself to check bool for completeness.    
        //}
        //public override void SwitchStep(bool isComplete)
        //{
        //    SetButtonInteractable();
        //    //check if step is complete.
        //    if (isComplete)
        //        ReturnToStep();
        //    else
        //        StartStep();        
        //}
        //public override void LeaveStep()
        //{
        //    highlighter.ChangeHighlightedState(false);
        //    ToggleInteractableState(maleToggle, femaleToggle);
        //}
        //public override void ReturnToStep()
        //{
        //    guiManager.RefreshInstructions(1);
        //    highlighter.ChangeHighlightedState(true);
        //    ToggleInteractableState(maleToggle, femaleToggle);
        //}
        //public override void StartStep()
        //{
        //    ReturnToStep();              
        //    ResetStep();
        //}        
        //public override void ResetStep()
        //{
        //    ratioText.text = "";
        //    ratioString = "";
        //    Gender.userRatio = 0;
        //    maleToggle.isOn = false;
        //    femaleToggle.isOn = false;        
        //}
        //public override void AreButtonsInteractable()
        //{

        //}
        //private void RefreshRatio(float ratio)
        //{
        //    ratioText.text = ratio.ToString(".00");
        //}    
        #endregion
    }
}
