using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;
//using static System.Net.Mime.MediaTypeNames;

public class buttonText : MonoBehaviour
{
    public TMP_Text Textfield;

    /*
    void Start()
    {
        Textfield = GetComponent<TextMeshProUGUI>();
    }
    */
    public void SetText(string text)
    { Textfield.text = text; }

    public void AppendText(string text)
    {
        text = "\n" + text;
        Textfield.text += text; }

    public void AppendTextByLetter(char letter)
    {
        Textfield.text += letter;
    }

    public void ToggleText()
    {
        if (Textfield.enabled == true)
        {
            Textfield.enabled = false;
        }
        else
        {
            Textfield.enabled = true;
        }
    }
}
