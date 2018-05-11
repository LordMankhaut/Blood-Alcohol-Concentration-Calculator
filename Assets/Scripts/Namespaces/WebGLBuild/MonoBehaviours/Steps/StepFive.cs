using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace WebGLBuild
{
    public class StepFive : Step
    {
        #region FIELD

        private const EScenes stepNumber = EScenes.SceneFive;

        #endregion

        #region PROPERTIES

        public override bool IsComplete { get { return isComplete; } set { isComplete = value; } }

        public override EScenes StepNumber { get { return stepNumber; } }
        #endregion

        #region METHODS

        
        #endregion

        public override void Begin()
        {
            throw new NotImplementedException();
        }

        public override void Return()
        {
            throw new NotImplementedException();
        }

        public override void Leave()
        {
            throw new NotImplementedException();
        }





        
        //public override bool IsComplete { get; set; }

        //public override void AreButtonsInteractable() { }

    }

}
