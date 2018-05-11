


namespace PatternTemplates
{
    /// <summary>
    /// 
    /// </summary>
    public interface IObserver
    {
        Subject Subject { get; set; }
        string ObserverStringState { get; set; }
        int ObserverIntegerState { get; set; }
        void SynchronizeSubjectStates();
        void RefreshDisplayedValues();
    }
}