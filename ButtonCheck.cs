using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCheck : MonoBehaviour
{

    public void SetText(string text)
    {
        Text txt = transform.Find("Test").GetComponent<Text>();
        txt.text = text;
    }

}
