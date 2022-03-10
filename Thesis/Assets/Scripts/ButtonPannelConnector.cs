using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonPannelConnector : MonoBehaviour, IPointerClickHandler
{
    private DataContainer data;
    private ButtonsDataSO currentButt;
    private void Awake()
    {
        data = GameObject.FindObjectOfType<DataContainer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        FindButton();
    }
    private void FindButton()
    {
        foreach(DataContainer.SoAndButtonsList soAndButtonsList in data.currentData)
        {
            foreach(Button button in soAndButtonsList.buttonsData)
            {

                if(button.gameObject.name.ToLower().Contains(gameObject.name.ToLower()))
                {

                    currentButt.mainButton=button;
                    currentButt.text=soAndButtonsList.sO.text;

                }

            }


        }

    }
    // Update is called once per frame
    void Update()
    {

    }
    void IPointerClickHandler.OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
    {
        FindButton();
        data.textToInteract.text=currentButt.text;
    }
}
