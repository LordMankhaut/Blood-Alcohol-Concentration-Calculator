using System.Collections.Generic;
/// <summary>
/// Contains the text strings to be displayed by the Notebook.
/// </summary>
public static class Dialogue
{
    #region FIELD
    //The current index of the list of instructions.
    public static int instructionIndex;
    public const string
        //Scene00
        message01 = "Step 1.\n\n Click the start button below to record your start time.\n\n  ",
        message02 = "Step 1.\n\n Click the start button below to record your start time.\n\n  " +
        "Useful information will appear here on the left.\n\n  " +
        "On the right, your blood alcohol concentration will be calculated with the values you enter.",
        message11 = "Start time I have recorded the current time as the time you started drinking.  " +
        "If this is correct, save to continue.  Otherwise, you can edit it below.",
        message21 = "Step 2.\n\n" +
        "Your start time is the current time.\n\n" +
        "If this is not correct, you can change it below.\n\n" +
        "Otherwise, click to continue.",
        message23 = "Now that we established a starting time, I can calculate your estimated maximum concentration.  " +
        "Will you use the information I have saved for you or is this a different user?",
        message22 = "The information I currently have is for 'name' , is that correct?",
        message31 = "Great, another user!  Enter your name and select your gender below.",
        message32 = "I want a name to display who's information I currently am using." +
        "It will not be displayed. " +
        "Enter your information as discreetly as you need to and save to progress to the next step.  " +
        "The gender and weight is not displayed." +
        "Anyone looking will only be able to make fun of your name.",
        message33 = "Gender is used to determine what percentage of your body weight is water (in other words, able to dilute the alcohol).",
        message34 = "On average, men have more body water than women.  " +
        "68% for men, and 55% for women." +
        "We will multiply your entered weight by this amount and convert it to grams for the calculation.",
        message35 = "Now that I know who you are, and all your most intimate personal details, " +
        "just let me know when you have had a drink and be as accurate as possible." +
        "I strongly recommend asking your bartender for precise measurements and alcohol percentages." +
        "They love it when you do that." +
        "If you aren't sure, though, you can use the default settings or enter your best guess.",
        message36 = "";
             
    #endregion

    #region METHODS
    public static void AddInstructionsToList(List<string> list)
    {
        //list.Add(stepOneMessage);
        //list.Add(stepTwoMessage);
        //list.Add(stepThreeMessage);
        //list.Add(stepFourMessage);
        //list.Add(stepFiveMessage);
        //list.Add(stepSixMessage);
        //list.Add(stepSevenMessage);
        //list.Add(stepEightMessage);
        //list.Add(instructions09);
        //list.Add(instructions10);
        //list.Add(instructions11);
        //list.Add(instructions12);
        //list.Add(instructions13);
    }
    #endregion
}