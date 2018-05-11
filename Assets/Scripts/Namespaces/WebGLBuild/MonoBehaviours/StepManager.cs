using UnityEngine;
using System.Collections.Generic;

namespace WebGLBuild
{
    /// <summary>
    /// Base class designed to make sure all derived steps have the requisite methods and properties.
    /// </summary>
    public class StepManager : MonoBehaviour
    {
        #region FIELD 
        private GUIImageManager imageManager;
        public StepNavigationOptions options;
        #region ISteps
        //All steps the user can be on.
        private IStep stepZero;
        private IStep stepOne;
        private IStep stepTwo;
        private IStep stepThree;
        private IStep stepFour;
        private IStep stepFive;
        private IStep stepSix;
        private IStep stepSeven;
        private IStep stepEight;
        //Current step the user is on.
        public IStep currentStep;

        public List<IStep> allSteps = new List<IStep>();
        #endregion
        #endregion

        #region PROPERTIES
        #region ISteps    
        public virtual IStep StepZero
        {
            get { return stepZero; }
        }
        public virtual IStep StepOne
        {
            get { return stepOne; }
        }
        public virtual IStep StepTwo
        {
            get { return stepTwo; }
        }
        public virtual IStep StepThree
        {
            get { return stepThree; }
        }
        public virtual IStep StepFour
        {
            get { return stepFour; }
        }
        public virtual IStep StepFive
        {
            get { return stepFive; }
        }
        public virtual IStep StepSix
        {
            get { return stepSix; }
        }
        public virtual IStep StepSeven
        {
            get { return stepSeven; }
        }
        public virtual IStep StepEight
        {
            get { return stepEight; }
        }
        #endregion
        #endregion

        #region METHODS
        #region Unity
        private void Awake()
        {
            imageManager = FindObjectOfType<GUIImageManager>();
            stepOne = gameObject.AddComponent<StepOne>();
            stepTwo = gameObject.AddComponent<StepTwo>();
            stepThree = gameObject.AddComponent<StepThree>();
            stepFour = gameObject.AddComponent<StepFour>();
            stepFive = gameObject.AddComponent<StepFive>();
            stepSix = gameObject.AddComponent<StepSix>();
            stepSeven = gameObject.AddComponent<StepSeven>();
            stepEight = gameObject.AddComponent<StepEight>();
            //Set to default of StepZero at start.
            currentStep = stepZero;
        }
        private void Start()
        {
            allSteps.Add(stepZero);
            allSteps.Add(stepOne);
            allSteps.Add(stepTwo);
            allSteps.Add(stepThree);
            allSteps.Add(stepFour);
            allSteps.Add(stepFive);
            allSteps.Add(stepSix);
            allSteps.Add(stepSeven);
            allSteps.Add(stepEight);
        }
        #endregion

        #region Public
        public void ResetSteps()
        {
            foreach (var step in allSteps)
            {
                step.IsComplete = false;
            }
            currentStep = stepZero;
            currentStep.Begin();
            options = GatherOptions(currentStep);
        }
        public void SwitchToNextStep()
        {
            currentStep.Leave();
            currentStep = currentStep.NextStep;
            currentStep.Begin();
            options = GatherOptions(currentStep);

        }
        public void SwitchToPreviousStep()
        {
            currentStep.Leave();
            currentStep = currentStep.PreviousStep;
            currentStep.Begin();
            options = GatherOptions(currentStep);
        }
        public StepNavigationOptions GatherOptions(IStep currentStep)
        {
            //options = currentStep.ButtonSetup();
            return options;
        }
        #endregion
        #endregion
    }
}