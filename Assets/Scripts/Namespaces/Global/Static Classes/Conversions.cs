/// <summary>
/// Converts various units of measure.
/// </summary>
public static class Conversions
{    
    #region FIELD
    private const int   gramsInPound = 454;
    private const float 
        millilitersInOunce = 29.6f,
        gramsInMilliliter = 0.789f;                                 
    #endregion    

    #region METHODS    
    public static float ConvertPoundsToGrams(float pounds)
    {
        float kilograms = (pounds * gramsInPound) / 1000;
        return kilograms;
    }
    public static float ConvertKilosToPounds(float kilograms)
    {
        float pounds = (kilograms * 1000) / gramsInPound;
        return pounds;
    }
    public static float ConvertKilogramsToGrams(float kilograms)
    {
        float grams = kilograms * 1000;
        return grams;
    }
    public static float ConvertOuncesToMilliliters(float ounces)
    {
        float milliliters = ounces * millilitersInOunce;
        return milliliters;
    }
    public static float ConvertMillilitersToOunces(float milliliters)
    {
        float ounces = milliliters / millilitersInOunce;
        return ounces;
    }
    public static float ConvertLitersToMilliliters(float liters)
    {
        float milliliters = liters * 1000;
        return milliliters;
    }
    public static float ConvertLitersToOunces(float liters)
    {
        float ounces = liters * 1000 / millilitersInOunce;
        return ounces;
    }
    public static float ConvertLitersToGrams(float liters)
    {
        float grams = (liters * 1000) * gramsInMilliliter;
        return grams;
    }
    public static float ConvertMillilitersToLiters(float milliliters)
    {
        float liters = milliliters / 1000;
        return liters;
    }
    public static float ConvertMillilitersToGrams(float milliliters)
    {
        float grams = milliliters * gramsInMilliliter;
        return grams;
    }
    public static float ConvertCentilitersToMilliliters(float centiliters)
    {
        float milliliters = centiliters * 10;
        return milliliters;
    }       
    #endregion
}