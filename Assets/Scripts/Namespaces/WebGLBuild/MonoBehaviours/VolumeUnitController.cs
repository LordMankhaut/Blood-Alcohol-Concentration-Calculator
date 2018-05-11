using UnityEngine;
using UnityEngine.UI;

namespace WebGLBuild
{
    /// <summary>
    /// This handles all events related to the volume unit toggle group, drink unit switch and input field for number of drinks.
    /// </summary>
    public class VolumeUnitController : MonoBehaviour
    {
        #region FIELD
        [SerializeField] private bool isOunces;
        [SerializeField] private bool isDrinks;
        [Header("")]
        [SerializeField]
        private int numDrinks;
        [Header("")]
        [SerializeField]
        private InputField inputField;
        [SerializeField] private ToggleGroup toggleGroup;
        [SerializeField] private Toggle drinks;
        [SerializeField] private Toggle ounces;
        [SerializeField] private Toggle liters;
        [SerializeField] private Toggle currentToggle;
        [SerializeField] private Text text;
        private string ouncesToggleName;
        #endregion

        #region PROPERTIES
        public bool IsOunces
        {
            get { return isOunces; }
        }
        public bool IsDrinks
        {
            get { return isDrinks; }
        }
        public int NumDrinks
        {
            get { return numDrinks; }
        }
        #endregion

        #region METHODS
        private void Awake()
        {
            ouncesToggleName = ounces.name;
        }
        private void Start()
        {
            liters.isOn = true;
            SetIsOunces();
            drinks.isOn = false;
            SetIsDrinks();
            ResetDrinks();
            inputField.interactable = false;
            CheckCurrentToggle();
        }
        //Activate or deactivate the input field when Drinks checkbox is selected or deselected.
        public void ChangeInputFieldEnabledState()
        {
            if (isDrinks)
            {
                inputField.interactable = true;
                numDrinks = 0;
                text.text = "0";
            }
            else
            {
                inputField.interactable = false;
                numDrinks = 0;
                text.text = "";
                inputField.text = "";
            }
        }
        public void SetIsDrinks()
        {
            isDrinks = drinks.isOn;
        }
        public void SetIsOunces()
        {
            CheckCurrentToggle();
            isOunces = currentToggle.name == ouncesToggleName;
        }
        private void CheckCurrentToggle()
        {
            foreach (var item in toggleGroup.ActiveToggles())
            {
                if (item.isOn)
                {
                    currentToggle = item;
                    return;
                }
                else
                    print("There are no active Toggles currently on.");
            }
        }
        private void ResetDrinks()
        {
            inputField.text = "";
            text.text = "";
            numDrinks = 0;
        }
        public void DisplayInput()
        {
            numDrinks = int.Parse(inputField.text);
            text.text = inputField.text;
            inputField.text = "";
        }
        #endregion

    }
}
