using System;
//using UnityEngine;
using UnityEngine.UI;
//using System.Collections;

namespace WebGLBuild
{
    public class StepTwo : Step
    {
        #region FIELD

        private const EScenes stepNumber = EScenes.SceneTwo;

        private new bool
            isComplete,
            canReset,
            canGoToNext;

        private new const bool
            canGoToPrevious = true,
            canGo = false;

        #endregion

        #region PROPERTIES


        public override bool IsComplete { get { return isComplete; } set { value = isComplete; } }

        public override EScenes StepNumber { get { return stepNumber; } }
        #endregion

        #region METHODS

        #region Unity

        private void Start()
        {
            isComplete = false;
            canReset = true;
            canGoToNext = false;

        }

        #endregion

        #region Public

        public override void Begin()
        {
            foreach (Toggle toggle in toggleManager.weightUnit)
            {
                toggleManager.ChangeToggleInteractability(toggle, true);
            }

            //textManager.UpdateText(textManager.message, Dialogue.stepTwoMessage);
            imageManager.weightUnit.ChangeHighlightedState(true);

        }

        public override void Return()
        {
            throw new NotImplementedException();
        }

        public override void Leave()
        {
            foreach (var toggle in toggleManager.weightUnit)
            {
                toggleManager.ChangeToggleInteractability(toggle, false);
            }
            //textManager.UpdateText(textManager.message, Dialogue.stepThreeMessage);
            imageManager.weightUnit.ChangeHighlightedState(false);
        }



        #endregion

        #endregion

        //public override bool IsComplete { get; set; }

        //public override void AreButtonsInteractable() { }

    }
}