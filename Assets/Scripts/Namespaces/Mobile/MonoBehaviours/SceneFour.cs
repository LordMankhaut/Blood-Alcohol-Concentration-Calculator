using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace MobileBuild
{
    /// <summary>
    ///     //SceneFour: Main monitoring screen, with option to add a drink.
    ///     //1. Should update and display the BAC every fifteen seconds, if changed.
    ///     //2. Handle if user wants to enter another drink.
    ///     //3. Handle if user wants to end timer.
    ///     //4. Handle if user wants to exit program.
    ///     //5. Animation and sound when change in BAC level???
    ///     //6. Option to turn notifications off???
    ///     //
    /// </summary>
    public class SceneFour : SceneController
    {
        #region FIELD
        public Text 
            bacResult,
            drinkTypeText;

        public Image selectedDrinkImage;

        public List<Image> images;

        private float timeSinceLastCheck;
        private float secondsBetweenChecks;        
        #endregion

        #region METHODS
        #region Unity
        private void Start()
        {
            //Check to see if the user is drunk.  [Will need to make sure this Start() method is called each time scene is loaded.]
            if (MainController.isDrunk)
            {
                StartCoroutine(UpdateBAC());
            }
        }
        #endregion

        #region Public
        public void Add()
        {
            //FadeOut(smallFader);
            //Play Audio.
            //Collect garbage.
            //Wait until animation transitions.
            //Switch to the drink selection, volume, percentage scene.
        }
        #endregion

        #region Private
        private IEnumerator UpdateBAC()
        {
            //Perform update. Call static method to calculate and return static value as result.

            //Display the result.

            yield return waitFor15Seconds;
        }

        public void SelectDrink(int i)
        {
            MainController.drinkType = (SelectedDrinkType)i;

        }
        #endregion
        #endregion        
    }
}