using TMPro;
using UnityEngine;
using UnityEngine.UI;
using FontStyles = TMPro.FontStyles;

public class ItalicToggleController : MonoBehaviour
{
    private Toggle toggle;
    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        toggle = GetComponent<Toggle>();
    }

    public void onToggleItalic()
    {
        if (toggle.isOn)
            text.fontStyle |= FontStyles.Italic;
        else
            text.fontStyle ^= FontStyles.Italic;
    }
}