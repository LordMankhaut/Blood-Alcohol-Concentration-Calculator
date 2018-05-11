using UnityEngine;

namespace WebGLBuild
{
    /// <summary>
    /// Step is the base class that is not placed on a game object in the hierarchy.
    /// StepManager will add components to itself that are derived from this class.
    /// </summary>
    public abstract class Step : MonoBehaviour, IStep
    {
        #region FIELD
        protected StepManager stepManager;
        protected GUIToggleManager toggleManager;
        protected GUITextManager textManager;
        protected GUIImageManager imageManager;
        protected GUIInputFieldManager inputFieldManager;
        protected IStep nextStep;
        protected IStep previousStep;
        public StepNavigationOptions buttonOptions;
        protected bool canReset = false,
            canGoToPrevious = true,
            canGoToNext = false,
            canGo = false,
            isComplete = false;
        #endregion

        #region PROPERTIES
        public virtual IStep NextStep { get { return nextStep; } }
        public virtual IStep PreviousStep { get { return previousStep; } }
        public virtual bool IsComplete { get; set; }
        public abstract EScenes StepNumber { get; }
        #endregion

        #region METHODS

        #region Unity
        protected virtual void Awake()
        {
            stepManager = FindObjectOfType<StepManager>();
            toggleManager = FindObjectOfType<GUIToggleManager>();
            textManager = FindObjectOfType<GUITextManager>();
            imageManager = FindObjectOfType<GUIImageManager>();
            inputFieldManager = FindObjectOfType<GUIInputFieldManager>();
        }
        #endregion

        #region Public    
        public virtual StepNavigationOptions ButtonSetup()
        {
            return buttonOptions;
        }
        public abstract void Begin();
        public abstract void Return();
        public abstract void Leave();
        #endregion

        #endregion

    }
}
