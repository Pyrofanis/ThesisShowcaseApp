using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextContentSizeFinder : MonoBehaviour
{
    private Vector2 currentVerticalSize, initialOffsetMax;
    private RectTransform rect;
    private TextMeshProUGUI tmpproCurrent;
    private ScrollRect scroll;

    private void Awake()
    {
        rect = GetComponent<RectTransform>();
        scroll = GetComponentInParent<ScrollRect>();
    }
    // Start is called before the first frame update
    void Start()
    {
        initialOffsetMax = rect.offsetMax;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Orders()
    {

        GetCurrentEnabledChild();
        FindTextSize(); ;
        SetBottomSpace();

    }
    void FindTextSize()
    {
        tmpproCurrent.ForceMeshUpdate();
        currentVerticalSize = tmpproCurrent.GetRenderedValues();
    }
    private void GetCurrentEnabledChild()
    {
        tmpproCurrent = GetComponentInChildren<TextMeshProUGUI>();


    }
    private void SetBottomSpace()
    {
        Vector2 previousMaxVector = rect.offsetMax;
        rect.offsetMin = new Vector2(rect.offsetMin.x, -currentVerticalSize.y + 0.1f * currentVerticalSize.y);
        rect.offsetMax = new Vector2(rect.offsetMax.x, 1);
        rect.ForceUpdateRectTransforms();
    }
}
