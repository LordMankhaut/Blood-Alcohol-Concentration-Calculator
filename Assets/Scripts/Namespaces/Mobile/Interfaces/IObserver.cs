


namespace MobileBuild
{
    /// <summary>
    /// 
    /// </summary>
    public interface IObserver
    {
        Subject Subject { get; set; }
        string ObserverStringState { get; set; }
        int ObserverIntegerState { get; set; }
        void Synchronize();
        void RefreshDisplayedValues();
    }
}