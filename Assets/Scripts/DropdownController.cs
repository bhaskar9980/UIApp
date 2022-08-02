using UnityEngine;
using TextMeshProUGUI = TMPro.TextMeshProUGUI;

public class DropdownController : MonoBehaviour
{
    private TMPro.TMP_Dropdown dropdown;
    [SerializeField] private TextMeshProUGUI text;
    public TMPro.TMP_FontAsset fontAsset1, fontAsset2, fontAsset3, fontAsset4, fontAsset5;

    private void Start()
    {
        dropdown = gameObject.GetComponent<TMPro.TMP_Dropdown>();
    }

    public void FontChanger()
    {
        if (dropdown.value == 0)
            text.font = fontAsset1;
        else if (dropdown.value == 1)
            text.font = fontAsset2;
        else if (dropdown.value == 2)
            text.font = fontAsset3;
        else if (dropdown.value == 3)
            text.font = fontAsset4;
        else if (dropdown.value == 4)
            text.font = fontAsset5;
    }
}