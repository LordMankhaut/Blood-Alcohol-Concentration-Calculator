using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace WebGLBuild
{
    public class GUIToggleManager : MonoBehaviour
    {
        #region FIELD

        private GUIManager guiManager;

        public Toggle
            male,
            female,
            pounds,
            kilograms,
            beer,
            wine,
            distilled,
            liters,
            ounces,
            drinks,
            custom,
            defaultVolume,
            customPercent,
            defaultPercent;

        public List<Toggle>
            gender,
            weightUnit,
            drinkType,
            volumeUnit,
            customDefault,
            percent = new List<Toggle>();

        public List<List<Toggle>> allToggles = new List<List<Toggle>>();

        #endregion

        #region METHODS

        #region Unity

        private void Awake()
        {
            guiManager = FindObjectOfType<GUIManager>();
        }

        private void Start()
        {
            gender.Add(male);
            gender.Add(female);
            weightUnit.Add(pounds);
            weightUnit.Add(kilograms);
            drinkType.Add(beer);
            drinkType.Add(wine);
            drinkType.Add(distilled);
            volumeUnit.Add(liters);
            volumeUnit.Add(ounces);
            volumeUnit.Add(drinks);
            customDefault.Add(custom);
            customDefault.Add(defaultVolume);
            percent.Add(customPercent);
            percent.Add(defaultPercent);
            allToggles.Add(gender);
            allToggles.Add(weightUnit);
            allToggles.Add(drinkType);
            allToggles.Add(volumeUnit);
            allToggles.Add(customDefault);
            allToggles.Add(percent);

            ResetAllToggles();
        }

        #endregion

        public void ResetAllToggles()
        {
            foreach (var list in allToggles)
            {
                foreach (var toggle in list)
                {
                    toggle.isOn = false;
                    toggle.interactable = false;
                }
            }
        }

        public void ChangeToggleInteractability(Toggle toggle, bool interactable)
        {
            toggle.interactable = interactable;
        }

        public void GenderSelected(bool isMale)
        {
            guiManager.GenderChanged(isMale);
        }

        public void WeightUnitSelected(bool isPounds)
        {
            guiManager.WeightUnitChanged(isPounds);

        }

        #endregion

    }
}
