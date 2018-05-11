using System;

namespace MobileBuild
{
    [Serializable]
    public class User
    {
        private string name;
        private float weight;
        private bool isMale;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public bool IsMale
        {
            get { return isMale; }
            set { isMale = value; }
        }
    }
}