using UnityEngine;

namespace MobileBuild
{
    /// <summary>
    /// Exits the program.  Attached to the Exit Button.
    /// </summary>
    public class Exit : MonoBehaviour
    {
        public void ExitProgram()
        {
            Application.Quit();
        }
    }
}