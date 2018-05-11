/// <summary>
/// Values and methods related to the weight calculation.
/// </summary>
#region ENUMERATION
public enum WeightUnits
{
    Pound, Kilogram
}
#endregion
public static class Weight
{
    #region FIELD
    public static WeightUnits weightUnit;
    public static float 
        weightInput,
        weightInGrams;    
    #endregion

    #region METHODS
    public static void DetermineRawWeight(WeightUnits unit, float weight, out float rawWeight)
    {
        switch (unit)
        {
            case WeightUnits.Pound:
                {
                    rawWeight = Conversions.ConvertPoundsToGrams(weight) * Gender.userRatio;
                    break;
                }
            case WeightUnits.Kilogram:
                {
                    rawWeight = Conversions.ConvertKilogramsToGrams(weight) * Gender.userRatio;
                    break;
                }
            default:
                {
                    rawWeight = 0;
                    break;
                }
        }

    }
    public static void Clear()
    {
        weightInput = 0f;
        weightInGrams = 0f;        
    }
    #endregion
}