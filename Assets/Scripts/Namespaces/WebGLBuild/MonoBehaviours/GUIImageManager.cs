using UnityEngine;
using System.Collections.Generic;

namespace WebGLBuild
{
    /// <summary>
    /// 
    /// </summary>
    public class GUIImageManager : MonoBehaviour
    {
        #region FIELD
        public Highlighter
            gender,
            weightUnit,
            weightInput,
            drinkType,
            volumeUnit,
            volumeInput,
            percent,
            viewRaw,
            time,
            go;
        public List<Highlighter> highlighters;
        #endregion

        #region METHODS
        private void Start()
        {
            highlighters.Add(gender);
            highlighters.Add(weightUnit);
            highlighters.Add(weightInput);
            highlighters.Add(drinkType);
            highlighters.Add(volumeUnit);
            highlighters.Add(volumeInput);
            highlighters.Add(percent);
            highlighters.Add(viewRaw);
            highlighters.Add(time);
            highlighters.Add(go);
        }
        public void NormalColor()
        {
            foreach (var highlighter in highlighters)
            {
                highlighter.ChangeHighlightedState(false);
            }
        }
        public void NormalColor(Highlighter highlighter)
        {
            highlighter.ChangeHighlightedState(false);
        }
        public void HighlightColor(Highlighter highlighter)
        {
            highlighter.ChangeHighlightedState(true);
        }
        #endregion
    }
}
