using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgresBarUI : MonoBehaviour
{
    [SerializeField]
    private float maxValue = 100;
    [SerializeField]
    private float startingValue = 100;

    private float curValue;

    [SerializeField]
    private RectTransform barFill;

    void Start()
    {
        UpdateProgresBar(startingValue);
    }

    public void UpdateProgresBar(float newValue)
    {
        if(newValue < 0)
        {
            curValue = 0;
        } else if(newValue > maxValue)
        {
            curValue = maxValue;
        } else
        {
            curValue = newValue;
        }

        barFill.localScale = new Vector3(curValue / maxValue, barFill.localScale.y);
    }

    public void Update()
    {
        barFill.localScale = new Vector3(curValue / maxValue, barFill.localScale.y);
    }
}
