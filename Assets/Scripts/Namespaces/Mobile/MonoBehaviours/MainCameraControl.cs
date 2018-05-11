using UnityEngine;

namespace MobileBuild
{
    public class MainCameraControl : MonoBehaviour
    {
        public static MainCameraControl cameraControl;

        private void Awake()
        {
            //Camera Persistence
            if (cameraControl == null)
            {
                DontDestroyOnLoad(gameObject);
                cameraControl = this;
            }
            else if (cameraControl != null)
            {
                Destroy(this);
            }
        }
    }
}