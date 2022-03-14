using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonPannelConnector : MonoBehaviour, IPointerClickHandler
{
    private DataContainer data;
    private Button currentButt;
    private string currentText;
    private TextContentSizeFinder sizeAdjuster;
    private void Awake()
    {
        data = GameObject.FindObjectOfType<DataContainer>();
        sizeAdjuster=GameObject.FindObjectOfType<TextContentSizeFinder>();
        currentButt = null;
    }

    // Start is called before the first frame update
    void Start()
    {
        FindButton();
    }
    private void FindButton()
    {
        foreach (DataContainer.SoAndButtonsList soAndButtonsList in data.currentData)
        {
            foreach (Button button in soAndButtonsList.buttonsData)
            {
                if (button.gameObject.name.ToLower().Equals(gameObject.name.ToLower()))
                {
                    if (button.gameObject.name != null)
                    {
                        currentButt = button;
                        currentText = soAndButtonsList.sO.text;
                    }


                }

            }


        }

    }

    void IPointerClickHandler.OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
    {
        Debug.Log(currentButt); //debug msg
        data.textToInteract.text = currentText;
        sizeAdjuster.Orders();
    }
}
