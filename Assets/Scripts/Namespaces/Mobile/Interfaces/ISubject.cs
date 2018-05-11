


namespace MobileBuild
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISubject
    {
        int SubjectIntegerState { get; set; }
        string SubjectStringState { get; set; }
        Observer[] Observers { get; set; }
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify();
    }
}