using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour
{
    //Reference to button to access its components
    private Button continueButton;

    //this get the Transitions of the Button as its pressed
    private ColorBlock colour;

    // Use this for initialization
    void Awake()
    {
        continueButton = GetComponent<Button>();
        colour = GetComponent<Button>().colors;

    }


    /// <summary>
    /// Example
    /// just add this to your Button component On Click()
    /// </summary>
    public void ButtonTransitionColors()
    {
        //Color highlightedColour = new Color(81, 241, 88);
        //Color normalColour = new Color(255, 255, 255);
        //Color pressedColour = new Color(81, 241, 88);

        //colour.highlightedColor = new Color(81, 241, 88);
        //colour.normalColor = Color.white;
        //colour.pressedColor = Color.white;

        //continueButton.colors = colour;




        colour.highlightedColor = Color.green;
        colour.normalColor = Color.white;
        colour.pressedColor = Color.white;

        continueButton.colors = colour;

    }
}

