using System;

namespace WebGLBuild
{
    public class StepThree : Step
    {
        #region FIELD

        private const EScenes stepNumber = EScenes.SceneThree;


        #endregion

        #region PROPERTIES



        public override bool IsComplete { get { return isComplete; } set { value = isComplete; } }

        public override EScenes StepNumber { get { return stepNumber; } }

        #endregion

        #region METHODS

       

        #region Public

        public override void Begin()
        {
            inputFieldManager.weight.interactable = true;
            imageManager.weightInput.ChangeHighlightedState(true);
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

        #endregion
        //public override bool IsComplete { get; set; }

        //public override void AreButtonsInteractable() { }

    }
}


