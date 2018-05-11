using UnityEngine;
using UnityEngine.UI;

namespace WebGLBuild
{
    /// <summary>
    /// Attach to a game object with an image component to change the color property of it.
    /// This is meant to provide visual feedback of a change in mode and a sign pointing towards the next step.
    /// </summary>
    public class Highlighter : ChangeImageColor
    {
        #region FIELD

        public bool isGroup;
        public int order;


        //private bool isHighlighted;


        #region Colors
        [SerializeField] private Color normalColor;
        [SerializeField] private Color highlightedColor;
        #endregion

        #endregion

        #region PROPERTIES

        #region Colors
        //This class must implement the abstract properties of the base class.
        public override Color Color1
        {
            get
            {
                return normalColor;
            }
            set
            {
                normalColor = value;
            }
        }
        public override Color Color2
        {
            get
            {
                return highlightedColor;
            }
            set
            {
                highlightedColor = value;
            }
        }
        #endregion

        #endregion

        #region METHODS

        #region Unity
        //Start is called on the attached component script because different images may start in either highlighted or normal state.
        private void Awake()
        {
            image = GetComponent<Image>();
        }
        #endregion

        #region State
        public void ChangeHighlightedState(bool highlighted)
        {
            if (highlighted)
            {
                ChangeColor(Color2);
            }
            else
            {
                ChangeColor(Color1);
            }
        }
        #endregion

        #endregion
    }
}
