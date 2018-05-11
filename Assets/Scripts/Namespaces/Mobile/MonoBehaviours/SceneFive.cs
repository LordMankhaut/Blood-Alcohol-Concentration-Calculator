using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace MobileBuild
{
    public enum SelectedDrinkType
    {
        Beer = 1,
        Wine = 2,
        Distilled = 3
    }

    public class SceneFive : SceneController
    {
        public Text
            litersText,
            ouncesText,
            volumeInGramsText,
            totalDoseConsumed,
            percentText,
            currentDosageText,
            drinkTypeText;

        private float 
            volumeInGrams,
            selectedPercent,
            currentDosage,
            beerMaxPercent = 15,
            wineMaxPercent = 25,
            distilledMaxPercent= 100;

        private SelectedDrinkType drinkType;
            
        public Slider 
            volumeSlider,
            percentSlider;

        public Image drinkImage;

        public List<Image> images;

        private void Start()
        {
            drinkType = MainController.drinkType;
            switch (drinkType)
            {
                case SelectedDrinkType.Beer:
                    {
                        percentSlider.maxValue = beerMaxPercent;
                        drinkImage.sprite = images[0].sprite;
                        drinkTypeText.text = "Beer";
                        break;
                    }
                case SelectedDrinkType.Wine:
                    {
                        percentSlider.maxValue = wineMaxPercent;
                        drinkImage.sprite = images[2].sprite;
                        drinkTypeText.text = "Wine";
                        break;
                    }
                case SelectedDrinkType.Distilled:
                    {
                        percentSlider.maxValue = distilledMaxPercent;
                        drinkImage.sprite = images[1].sprite;
                        drinkTypeText.text = "Distilled";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        public void UpdateVolume()
        {
            litersText.text = volumeSlider.value.ToString("0.00");
            ouncesText.text = Conversions.ConvertLitersToOunces(volumeSlider.value).ToString("0.00");
            volumeInGrams = Conversions.ConvertLitersToGrams(volumeSlider.value);
            volumeInGramsText.text = volumeInGrams.ToString("0.00");
            UpdateDose();           
        }

        public void SaveAndContinue()
        {
            MainController.userVolumeConsumed += volumeInGrams;
            MainController.userTotalDose += currentDosage;
        }
        

        public void UpdatePercentage()
        {
            selectedPercent = percentSlider.value;
            percentText.text = selectedPercent.ToString("0.00");
            UpdateDose();
        }

        public void UpdateDose()
        {
            currentDosage = volumeInGrams * (selectedPercent/ 100);
            currentDosageText.text = currentDosage.ToString("0.00");
        }
    }
}