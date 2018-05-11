


#region ENUMERATIONS
public enum DrinkTypes
{
    Beer = 1,
    Wine = 2,
    Distilled = 3
}
public enum VolumeUnits
{
    Liters,
    Ounces,
    Centiliters,
    Milliliters
}
#endregion

/// <summary>
///     //1.Store constants for default volumes.
///     //2.Determine dose.
///     //3.Convert dose to grams.
/// </summary>
public static class Alcohol 
{
    #region FIELD
    //Reference the drink type enumerator.
    public static DrinkTypes type;
    //Reference the volume unit enumerator.
    public static VolumeUnits volumeUnit;
    //Create float values...
    public static float 
        //to hold the total volume that has been reported.
        totalVolume,
        //to hold the current volume being reported/added to the calculation. 
        volumeInGrams,
        //to hold the current percent of alcohol being reported.
        percentAlcohol,
        //to hold the total number of drinks reported.  [This will be total dose / 14g.]
        numDrinks,
        //to hold the current dose of the currently reported drink.
        doseInGrams,
        //to hold the total dose consumed.
        totalDose;
    //Create float values...
    public const float
        //to store the default beer percentage.
        defaultBeerPercent = 0.05f,
        //to store the default wine percentage.
        defaultWinePercent = 0.12f,
        //to store the default distilled spirits percentage.
        defaultDistilledPercent = 0.4f,
        //to store the default beer volume in ounces.
        defaultBeerVolume = 12f,
        //to store the default wine volume in ounces.
        defaultWineVolume = 5f,
        //to store the default distilled volume in ounces.
        defaultDistilledVolume = 1.5f,
        //to store the default beer volume in Liters.
        defaultBeerVolumeInL = 0.355f,
        //to store the default wine volume in cL.
        defaultWineVolumeInCL= 14.8f,
        //to store the default distilled volume in cL.
        defaultDistilledVolumeInCL = 4.44f;
    #endregion

    #region METHODS

    #region Public
    //Create a method to return the default percentage value for the passed in drink type.
    public static void DeterminePercent(DrinkTypes drink, out float percentAlcohol)
    {
        //Given the drink type...
        switch (drink)
        {
            //if beer...
            case DrinkTypes.Beer:
                {
                    //percent is default percent for beer.
                    percentAlcohol = defaultBeerPercent;
                    break;
                }
            //if wine...
            case DrinkTypes.Wine:
                {
                    //percent is default percent for wine.
                    percentAlcohol = defaultWinePercent;
                    break;
                }
            //if distilled...
            case DrinkTypes.Distilled:
                {
                    //percent is the default percent for distilled.
                    percentAlcohol = defaultDistilledPercent;
                    break;
                }
            //in any other case...
            default:
                {
                    //percent equals zero.
                    percentAlcohol = 0;
                    break;
                }
        }
    }    
    //Create a method to return the dose in grams of alcohol given the passed in volume and unit.
    public static void DetermineDose(VolumeUnits unit, float volume, out float doseInGrams)
    {
        //First get dose: multiply the volume by the alcohol percentage.
        volume *= percentAlcohol;
        //Given a volume unit...
        switch (unit)
        {
            //Get dose in grams from liters.
            case VolumeUnits.Liters:
                {
                    //Convert the dose in liters to dose in grams.
                    doseInGrams = Conversions.ConvertMillilitersToGrams(Conversions.ConvertLitersToMilliliters(volume));
                    //Stop
                    break;
                }
                //Get dose in grams from centiliters.
            case VolumeUnits.Centiliters:
                {
                    //Convert the dose in centiliters to grams.
                    doseInGrams = Conversions.ConvertMillilitersToGrams(Conversions.ConvertCentilitersToMilliliters(volume));
                    //Stop
                    break;
                }
                //Get dose in grams from ounces.
            case VolumeUnits.Ounces:
                {
                    //Convert the dose in ounces to grams.
                    doseInGrams = Conversions.ConvertMillilitersToGrams(Conversions.ConvertOuncesToMilliliters(volume));
                    //Stop
                    break;
                }
                //Get dose in grams from milliliters.
            case VolumeUnits.Milliliters:
                {
                    //Convert the dose in milliliters to grams.
                    doseInGrams = Conversions.ConvertMillilitersToGrams(volume);
                    //Stop
                    break;
                }
                //In all other cases....
            default:
                {
                    //Dose is zero.
                    doseInGrams = 0;
                    //Stop
                    break;
                }
        }
    }
    //Clear the values in the local variables. [Why did I need this?]
    public static void Clear()
    {
        totalVolume = 0;
        volumeInGrams = 0;
        percentAlcohol = 0;
        numDrinks = 0;
        doseInGrams = 0;
        totalDose = 0;
    }
    #endregion

    #endregion
}