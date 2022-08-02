using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SlideController : MonoBehaviour
{
    private Slider slider;
    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        slider = GetComponent<Slider>();
        slider.minValue = 85;
        slider.maxValue = 150;
    }

    public void UpdateFontSize()
    {
        text.fontSize = slider.value;
    }
}