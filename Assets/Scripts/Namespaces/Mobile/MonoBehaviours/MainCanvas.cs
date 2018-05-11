using UnityEngine;
using System.Collections;

namespace MobileBuild
{
    public class MainCanvas : MonoBehaviour
    {
        public static MainCanvas canvas;

        private void Awake()
        {
            //Canvas Persistence
            if (canvas == null)
            {
                DontDestroyOnLoad(gameObject);
                canvas = this;
            }
            else if (canvas != this)
            {
                Destroy(this);
            }
        }
    }
}