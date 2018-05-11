


namespace PatternTemplates
{
    /// <summary>
    /// 
    /// </summary>
    public class ConcreteSubject : Subject
    {
        #region PROPERTIES
        public override Observer[] Observers { get { return observers; } set { observers = value; } }
        public override string SubjectStringState { get { return subjectStringState; } set { subjectStringState = value; } }
        public override int SubjectIntegerState { get { return subjectIntegerState; } set { subjectIntegerState = value; } }
        #endregion
    }
}
