using TMPro;
using UnityEngine;
using UnityEngine.UI;
using FontStyles = TMPro.FontStyles;

public class BoldToggleController : MonoBehaviour
{
    private Toggle toggle;
    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        toggle = GetComponent<Toggle>();
    }

    public void onToggleBold()
    {
        if (toggle.isOn)
        {
            text.fontStyle |= FontStyles.Bold;
        }
        else
            text.fontStyle ^= FontStyles.Bold;
    }
}