namespace WebGLBuild
{
    /// <summary>
    /// 
    /// </summary>
    public static class Calculation
    {
        private static float
            ratio,
            inputWeight,
            weightInGrams,
            volumeInGrams,
            percent,
            drinks,
            doseInGrams,
            rawBAC,
            hours,
            timeModifier,
            BAC;

        public static float Calculate()
        {
            //Cache the current data in the local variables.
            GatherData();
            //Determine the dose in grams.
            //doseInGrams = (volume * percent)
            //Determine the weight in grams.

            //Determine the time modifier.

            //Perform base calculation;
            BAC = (doseInGrams / weightInGrams) * 100 * timeModifier;
            //Send the result to the caller.
            return BAC;
        }

        public static void GatherData()
        {
            ratio = Gender.userRatio;
            inputWeight = Weight.weightInput;
            weightInGrams = Weight.weightInGrams;
            volumeInGrams = Alcohol.totalVolume;
            percent = Alcohol.percentAlcohol;
            drinks = Alcohol.numDrinks;
            doseInGrams = Alcohol.doseInGrams;
            hours = Time.userInputHours;
        }
    }
}
