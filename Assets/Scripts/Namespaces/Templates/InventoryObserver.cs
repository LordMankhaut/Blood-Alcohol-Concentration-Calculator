using UnityEngine.UI;


namespace PatternTemplates
{
    /// <summary>
    /// 
    /// </summary>
    public class InventoryObserver : Observer
    {
        #region FIELD
        public Text inventoryTotal, inventoryName;
        #endregion

        #region PROPERTIES
        public override Subject Subject { get { return subject; } set { subject = value; } }
        public override string ObserverStringState { get { return observerStringState; } set { observerStringState = value; } }
        public override int ObserverIntegerState { get { return observerIntegerState; } set { observerIntegerState = value; } }
        #endregion

        #region METHODS
        private void Start()
        {
            RefreshDisplayedValues();
        }
        public override void SynchronizeSubjectStates()
        {
            ObserverStringState = Subject.SubjectStringState;
            ObserverIntegerState = Subject.SubjectIntegerState;
            RefreshDisplayedValues();
        }
        public override void RefreshDisplayedValues()
        {
            inventoryName.text = ObserverStringState;
            inventoryTotal.text = ObserverIntegerState.ToString();
        }
        #endregion
    }
}