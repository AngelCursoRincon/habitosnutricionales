using TMPro;
using UnityEngine;

public class ShowAPKVersion : MonoBehaviour
{
    public TextMeshProUGUI text;

    void Start()
    {
        text.text = "v" + Application.version;
    }
}

