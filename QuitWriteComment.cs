using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitWriteComment : MonoBehaviour
{

    public InputField comment;


    public void Save()
    {
        PlayerPrefs.SetString("Name", comment.text);

    }

    public void Load()
    {
        if (PlayerPrefs.HasKey("Name"))
        {
            comment.text = PlayerPrefs.GetString("Name");

        }
    }
}