using UnityEngine;
using UnityEngine.UI;

namespace MobileBuild
{
    /// <summary>
    ///     //Scene Three: Find out if user wants to continue with currently saved gender and weight or enter a new user.
    ///     //
    /// </summary>
    public class SceneThree : SceneController
    {
        #region FIELD
        public Image gender;
        public Text userInputName;
        public Text pounds;
        public Text kilos;
        public Toggle custom;
        private bool isCustom;
        public Slider weight;
        public Button saveAndContinueButton;
        public Image saveAndContinueButtonImage;
        public Text userName;
        public Text userWeight;
        public Text userGender;
        #endregion

        #region PROPERTIES
        public string Message31 { get { return Dialogue.message31; } }
        public string Message32 { get { return Dialogue.message32; } }
        #endregion

        #region METHODS
        #region Unity
        private void Start()
        {
            Begin();
        }
        #endregion

        #region Public
        public void UpdateWeight()
        {
            kilos.text = weight.value.ToString();
            pounds.text = Mathf.RoundToInt(Conversions.ConvertKilosToPounds(weight.value)).ToString();
            MainController.userWeight = Conversions.ConvertKilogramsToGrams(weight.value);
            userWeight.text = MainController.userWeight.ToString();            
        }
        public void UpdateName(string name)
        {
            MainController.userName = name;
            userName.text = name;
        }
        public void UpdateGender(bool isMale)
        {
            MainController.userIsMale = isMale;
            if (isMale)
            {
                userGender.text = "Male";
            }
            else userGender.text = "Female";            
        }
        public void EnableSaveAndContinue()
        {
            saveAndContinueButton.enabled = true;
            //Fade purple arrow image in.
        }
        #endregion

        #region Protected
        protected override void Begin()
        {
            UpdateNotebook();
            UpdateWeight();
        }
        protected override void UpdateNotebook()
        {
            notebook.UpdateLeftPage(Message31);
            notebook.UpdateRightPage(Message32);
        }
        #endregion
        #endregion
    }
}