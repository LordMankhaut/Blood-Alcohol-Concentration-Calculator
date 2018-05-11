using UnityEngine;


namespace PatternTemplates
{
    /// <summary>
    /// 
    /// </summary>
    public class Scene : MonoBehaviour
    {
        #region FIELD
        public Subject subject1;
        public Observer observer1;
        #endregion

        #region METHODS
        private void Start()
        {
            subject1.Attach(observer1);
        }
        #endregion
    }
}