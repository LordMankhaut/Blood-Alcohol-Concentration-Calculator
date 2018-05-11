using UnityEngine;


public class HelpOverlay : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void EnableDisableOverlay()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}