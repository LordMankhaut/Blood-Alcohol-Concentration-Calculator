using UnityEngine;
using UnityEngine.UI;

namespace WebGLBuild
{
    /// <summary>
    /// Base class that defines the basic references and method to change an image color.
    /// Derived class is attached to a game object and calls the base function.
    /// </summary>
    public abstract class ChangeImageColor : MonoBehaviour
    {
        #region FIELD    
        public EScenes step;
        protected Image image;
        #endregion

        #region PROPERTIES
        public abstract Color Color1 { get; set; }
        public abstract Color Color2 { get; set; }
        #endregion

        #region METHODS
        private void Awake()
        {
            if (!GetComponent<Image>())
            {
                throw new System.Exception("ChangeImageColor requires that an Image component is referenced.");
            }
            else
                image = GetComponent<Image>();
        }
        public void ChangeColor(Color color)
        {
            image.color = color;
        }
        #endregion
    }
}
