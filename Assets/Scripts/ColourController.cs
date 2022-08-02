using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColourController : MonoBehaviour
{
    private TMPro.TMP_Dropdown dropdown;
    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        dropdown = GetComponent<TMP_Dropdown>();
    }

    public void ChangeColour()
    {
        if (dropdown.value == 0)
            text.color = Color.black;
        else if (dropdown.value == 1)
            text.color = Color.red;
        else if (dropdown.value == 2)
            text.color = Color.green;
        else if (dropdown.value == 3)
            text.color = Color.blue;
        else if (dropdown.value == 4)
            text.color = Color.yellow;
        else if (dropdown.value == 5)
            text.color = Color.magenta;
    }
}