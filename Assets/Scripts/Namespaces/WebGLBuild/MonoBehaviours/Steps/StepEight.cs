using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace WebGLBuild
{
    public class StepEight : Step
    {
        #region FIELD

        private const EScenes stepNumber = EScenes.SceneEight;

        #endregion

        #region PROPERTIES

        public override EScenes StepNumber { get { return stepNumber; } }

        public override bool IsComplete { get { return isComplete; } set { isComplete = value; } }

        #endregion

        #region METHODS

        

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



        #endregion
        //public override bool IsComplete { get; set; }

        //public override void AreButtonsInteractable() { }

    }

}
