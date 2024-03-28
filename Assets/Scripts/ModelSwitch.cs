using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ModelSwitch : MonoBehaviour
{
    public GameObject AnimeGirl;
    public GameObject Bird;
    public int Manager;
    public TMP_Text Textfield;

    public void refreshCharacterDescription()
    {
        switch(Manager)
        {
            case 0:
                Cha_1();
                break;
            case 1:
                Cha_2();
                break;
        }
    }
    public void ManageCharacter()
    {
        if (Manager == 0)
        {
            Cha_2();
            Manager = 1;
        }
        else
        {
            Cha_1();
            Manager = 0;
        }
    }

    void Cha_1()
    {
        AnimeGirl.SetActive(true);
        Bird.SetActive(false);
        Textfield.SetText("You selected:AnimeGirl;");
    }

    void Cha_2()
    {
        Bird.SetActive(true);
        AnimeGirl.SetActive(false);
        SetText("You selected:The Bird;");
        AppendText("<style=\"WikiHead\">Dinosaurs</style>\r\n\r\nDinosaurs are a diverse group of reptiles[note 1] of the clade Dinosauria. They first appeared during the Triassic period, between 243 and 233.23 million years ago (mya), although the exact origin and timing of the evolution of dinosaurs is a subject of active research. They became the dominant terrestrial vertebrates after the Triassic–Jurassic extinction event 201.3 mya and their dominance continued throughout the Jurassic and Cretaceous periods. Dinosaurs can therefore be divided into avian dinosaurs—birds—and the extinct non-avian dinosaurs, which are all dinosaurs other than birds.\r\n.....\r\nDinosaurs are a diverse group of reptiles[note 1] of the clade Dinosauria. They first appeared during the Triassic period, between 243 and 233.23 million years ago (mya), although the exact origin and timing of the evolution of dinosaurs is a subject of active research. They became the dominant terrestrial vertebrates after the Triassic–Jurassic extinction event 201.3 mya and their dominance continued throughout the Jurassic and Cretaceous periods. Dinosaurs can therefore be divided into avian dinosaurs—birds—and the extinct non-avian dinosaurs, which are all dinosaurs other than birds.\r\n.....");
    }

    public void SetText(string text)
    { Textfield.text = text; }

    public void AppendText(string text)
    {
        text = "\n" + text;
        Textfield.text += text;
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
