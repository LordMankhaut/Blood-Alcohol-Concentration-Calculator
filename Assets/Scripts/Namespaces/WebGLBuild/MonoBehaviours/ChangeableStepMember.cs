using UnityEngine;
using System.Collections;

namespace WebGLBuild
{
    /// <summary>
    /// Attach to game object with a component that needs to be handled by another manager.  This will report itself as existing upon awake and fill a list of Game Objects.
    /// This also has an enumerator designating it as being for a certain step.  
    /// </summary>
    public class ChangeableStepMember : MonoBehaviour
    {
        #region FIELD

        #region Reporting to the GUIManager
        //Will need to report itself to the GUIManager.
        private GUIManager guiManager;
        public EScenes stepNumber;
        #endregion

        #region PROPERTIES
        public EScenes StepNumber { get { return stepNumber; } }
        #endregion

        #endregion

        #region METHODS
        #region Unity
        private void Start()
        {
            #region Reporting To The GUIManager
            guiManager = FindObjectOfType<GUIManager>();
            //guiManager.stepMembers.Add(this);
            #endregion
        }
        #endregion
        #endregion
    }

}
