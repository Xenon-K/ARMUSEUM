using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ModelSwitch : MonoBehaviour
{
    public GameObject AnimeGirl;
    public GameObject Bird;
    public GameObject Sam;
    public GameObject Chair;
    public int Manager;
    public TMP_Text Textfield;
    public ChatSystem chatSystem;
    /*
    private Animator samAnimator;

    private void Start()
    {
        samAnimator = Sam.GetComponent<Animator>();
    }
    */
    public void refreshCharacterDescription()
    {
        switch(Manager)
        {
            case 0:
                Cha_Car();
                break;
            case 1:
                Cha_Bird();
                break;
            case 2:
                Cha_Sam();
                break;
            case 3:
                Cha_Chair();
                break;
        }
    }
    public void ManageCharacter()
    {
        switch(Manager)
        { 
            case 0:
                Cha_Bird();
                Manager = 1;
                break;
            case 1:
                Cha_Sam();
                Manager = 2;
                break;
            case 2:
                Cha_Chair();
                Manager = 3;
                break;
            case 3:
                Cha_Car();
                Manager = 0;
                break;
        }
    }

    public void ManageCharacter_bkw()
    {
        switch (Manager)
        {
            case 0:
                Cha_Chair();
                Manager = 3;
                break;
            case 1:
                Cha_Car();
                Manager = 0;
                break;
            case 2:
                Cha_Bird();
                Manager = 1;
                break;
            case 3:
                Cha_Sam();
                Manager = 2;
                break;
        }
    }

    void allToFalse()
    {
        AnimeGirl.SetActive(false);
        Bird.SetActive(false);
        Sam.SetActive(false);
        Chair.SetActive(false);
    }

    void Cha_Car()
    {
        allToFalse();
        AnimeGirl.SetActive(true);
        Textfield.SetText("You selected: Car Type: Tridoron;");
        chatSystem.SetObjectName("Kamen Rider Drive");
    }

    void Cha_Bird()
    {
        allToFalse();
        Bird.SetActive(true);
        Textfield.SetText("You selected:The Bird;");
        AppendText("<style=\"WikiHead\">Dinosaurs</style>\r\n\r\nDinosaurs are a diverse group of reptiles[note 1] of the clade Dinosauria. They first appeared during the Triassic period, between 243 and 233.23 million years ago (mya), although the exact origin and timing of the evolution of dinosaurs is a subject of active research. They became the dominant terrestrial vertebrates after the Triassic–Jurassic extinction event 201.3 mya and their dominance continued throughout the Jurassic and Cretaceous periods. Dinosaurs can therefore be divided into avian dinosaurs—birds—and the extinct non-avian dinosaurs, which are all dinosaurs other than birds.\r\n.....\r\nDinosaurs are a diverse group of reptiles[note 1] of the clade Dinosauria. They first appeared during the Triassic period, between 243 and 233.23 million years ago (mya), although the exact origin and timing of the evolution of dinosaurs is a subject of active research. They became the dominant terrestrial vertebrates after the Triassic–Jurassic extinction event 201.3 mya and their dominance continued throughout the Jurassic and Cretaceous periods. Dinosaurs can therefore be divided into avian dinosaurs—birds—and the extinct non-avian dinosaurs, which are all dinosaurs other than birds.\r\n.....");
        chatSystem.SetObjectName("Archaeopteryx");
    }

    //bool applySwitch = true;
    void Cha_Sam()
    {
        allToFalse();
        Sam.SetActive(true);
        Textfield.SetText("You selected:Sam;");
        chatSystem.SetObjectName("Stellaron Hunter Sam");
        //samAnimator.applyRootMotion = !applySwitch;
        //applySwitch = !applySwitch;
        //samAnimator.applyRootMotion = true;
        //Invoke("delay", 3);
        //samAnimator.applyRootMotion = false;
    }

    void Cha_Chair()
    {
        allToFalse();
        Chair.SetActive(true);
        Textfield.SetText("<style=\"WikiHead\">Dante: Hey Vergil, your portal-opening days are over. Give me the Yamato.\r\n\r\nVergil: If you want it, then you'll have to take it. But you already knew that.\r\n\r\nDante: I had a feeling you'd say that...\r\n\r\nVergil: How many times have we fought?\r\n\r\nDante: Hard to say. It's the only memory I have of us since we were kids.\r\n\r\nTime to finish this, Vergil! Once and for all.</style>");
        chatSystem.SetObjectName("Vergil, from Devil May Cry");
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
