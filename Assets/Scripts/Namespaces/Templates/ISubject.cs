


namespace PatternTemplates
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISubject
    {
        int SubjectIntegerState { get; set; }
        Observer[] Observers { get; set; }
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify();
    }
}