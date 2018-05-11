using UnityEngine;
using UnityEngine.SceneManagement;

namespace MobileBuild
{
    /// <summary>
    ///     //Attached to game object "MainControl."
    ///     //1.Remains persistent through out session in every scene.
    ///     //2.Contains working variables that will be serialized and saved.///     
    ///     //3.Handles scene changes.
    ///     
    /// </summary>
    public class MainController : MonoBehaviour
    {
        #region FIELD
        //Reference to this instance of the class.
        public static MainController instance;
        //Create bool to keep track of whether the timer is started.
        public static bool isStarted = false;          
        //Create a boolean to track if the user has recorded at least one drink.
        public static bool isDrunk;
        //Create a string to hold the input name of the current user.
        public static string userName;
        //Create a float to hold the user's weight.
        public static float userWeight;
        //Create a bool to store the user's gender.
        public static bool userIsMale;
        public static int userStartHour;
        public static int userStartMinute;
        public static float userVolumeConsumed;
        public static float userTotalDose;
        public static SelectedDrinkType drinkType = SelectedDrinkType.Beer;
        #endregion

        #region METHODS
        #region Unity
        //Handle class persistence.
        private void Awake()
        {
            //Make sure this game object persists between scenes and is not duplicated.
            if (instance == null)
            {
                DontDestroyOnLoad(gameObject);
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(this);
            }            
        }
        #endregion

        #region Public
        //Call from scene controllers to change scene.
        public static void ChangeScene(string scene)
        {
            //Switch to a different scene with the name passed in.
            SceneManager.LoadScene(scene);
        }
        #endregion
        #endregion

        #region CONSTRUCTOR
        public MainController()
        {
            userIsMale = true;
            userWeight = 50f;
            userName = "MyName";
            userStartHour = 0;
            userStartMinute = 0;
            isStarted = false;
            isDrunk = false;
        }
        #endregion
    }
}