


/// <summary>
/// 
/// </summary>
namespace PatternTemplates
{
    public class ConcreteObserver : Observer
    {
        #region PROPERTIES
        public override Subject Subject { get { return subject; } set { subject = value; } }
        #endregion

        #region METHODS
        public override void SynchronizeSubjectStates()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}