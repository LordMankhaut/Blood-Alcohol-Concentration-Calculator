/// <summary>
/// Interface required for all step classes.
/// </summary>
public interface IStep
{
    //WebGLBuild.StepNavigationOptions ButtonSetup();
    EScenes StepNumber { get; }
    bool IsComplete { get; set; }     
    IStep NextStep { get; }
    IStep PreviousStep { get; }
    void Begin();
    void Return();
    void Leave();
}