using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Inputtext;
    [SerializeField] private TMPro.TMP_Dropdown Fontdropdown;
    [SerializeField] private TMPro.TMP_Dropdown Colourdropdown;
    [SerializeField] private Slider slider;
    [SerializeField] private Toggle Boldtoggle;
    [SerializeField] private Toggle Italictoggle;

    public void Reset()
    {
        Inputtext.ClearMesh();
        Fontdropdown.SetValueWithoutNotify(0);
        Colourdropdown.SetValueWithoutNotify(0);
        slider.SetValueWithoutNotify(slider.minValue);
        Boldtoggle.SetIsOnWithoutNotify(false);
        Italictoggle.SetIsOnWithoutNotify(false);
    }
}