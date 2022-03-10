using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DataContainer : MonoBehaviour
{
    public TextMeshProUGUI textToInteract;


    [System.Serializable]

    public struct SoAndButtonsList
    {

        [Header("Button text Name")]
        public List<Button> buttonsData;
        [HideInInspector]
        public Button mainButton;
        public ButtonsDataSO sO;
        public SoAndButtonsList(List<Button> newButtons, Button newMainButton, ButtonsDataSO sONew)
        {
            this.buttonsData = newButtons;
            this.sO = sONew;
            this.mainButton = newMainButton;

        }

    }

    [SerializeField]
    public List<SoAndButtonsList> currentData;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
