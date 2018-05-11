using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
    #region FIELD
    public Text textBox;
    [SerializeField] private string message;
    #endregion
    
    #region UNITY METHODS
    private void Start()
    {
        print(message);
    }

    public void OnMouseEnter()
    {
        print("OnMouseEnter()");
        textBox.text = message;
    }

    public void OnMouseOver()
    {
        print("OnMouseOver()");        
    }

    public void OnMouseExit()
    {
        print("OnMouseExit()");
        textBox.text = "";
    }
    #endregion    
}