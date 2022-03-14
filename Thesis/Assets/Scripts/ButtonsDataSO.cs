using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "buttonsDT", menuName = "Datacontainers/Data/Buttons/buttonsDT", order = 0)]
public class ButtonsDataSO : ScriptableObject
{
    [TextArea]
    public string text;
    public Button mainButton;
}
