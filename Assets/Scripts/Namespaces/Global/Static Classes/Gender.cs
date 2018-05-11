/// <summary>
/// The basic relevant information for each gender, and current selected gender.
/// </summary>
public static class Gender
{
    #region FIELD    
    public static float userRatio;
    public const float 
        maleRatio = 0.68f,
        femaleRatio = 0.55f;    
    #endregion

    #region METHODS
    public static void Clear()
    {
        userRatio = 0;
    }
    #endregion
}