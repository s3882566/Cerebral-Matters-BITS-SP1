using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
  
    
    private Button continueButton;

    void Awake()
    {
        continueButton = GetComponent<Button>();

    }




    public void OnPointerEnter(PointerEventData eventData)
    {
       

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponent<Image>().color = Color.white;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        GetComponent<Image>().color = Color.gray;
    }
}

