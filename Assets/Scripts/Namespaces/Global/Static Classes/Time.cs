using System;

/// <summary>
/// Some constant values related to the time calculation.
/// </summary>
public static class Time 
{
    #region FIELD
    public static float
        userInputHours,
        modifier;
    public static DateTime startTime;    
    private const float multiplier = 0.015f;
    #endregion



    #region METHODS
    public static void SetStartTime()
    {
        startTime = DateTime.Now;
    }
    public static void Clear()
    {
        userInputHours = 0;
        modifier = 0;
    }
    public static void Subtract15Minutes()
    {

    }
    public static void Subtract60Minutes()
    {

    }
    #endregion
}