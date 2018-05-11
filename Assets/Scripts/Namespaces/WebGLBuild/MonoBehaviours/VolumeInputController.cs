using UnityEngine;
using UnityEngine.UI;

namespace WebGLBuild
{
    /// <summary>
    /// This class controls the user input and ability to choose custom amounts or calculate defaults valumes.
    /// </summary>
    public class VolumeInputController : MonoBehaviour
    {
        VolumeUnitController volumeUnitController;

        [SerializeField] private InputField inputField;
        [SerializeField] private ToggleGroup toggleGroup;
        [SerializeField] private Toggle customToggle;
        [SerializeField] private Toggle defaultToggle;
        [SerializeField] private Text calculatedVolumeText;
    }

}
