using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VisualizationScript : MonoBehaviour
{
    [Range(0, 100)]
    [SerializeField]
    private float minValue;
    [Range(0, 100)]
    [SerializeField]
    private float maxValue;
        [SerializeField]
    [Range(0, 4)]
    private float minDelay;
       [SerializeField]
    [Range(0, 4)]
    private float maxDelay;

    private TextMeshProUGUI currentTmpro;
    private float currentValue;
    private float randomIntervals = 5, timer;
    // Start is called before the first frame update
    void Start()
    {
        currentTmpro = GetComponent<TextMeshProUGUI>();
        PrepareValues();
    }
    private void PrepareValues()
    {

        currentValue = Random.Range(minValue, maxValue);
        randomIntervals = Random.Range(minDelay, maxDelay);
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= randomIntervals)
        {
            currentTmpro.text=currentValue.ToString("0");
            PrepareValues();
            timer=0;
        }

    }
}
