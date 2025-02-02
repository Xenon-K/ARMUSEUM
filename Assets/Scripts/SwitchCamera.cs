using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script to change the camera between AR View (UI Camera) and Model View Room
public class SwitchCamera : MonoBehaviour
{
    public GameObject Camera_1; //UI Camera
    public GameObject Camera_2; //MVR Camera
    public GameObject Camera_3; //Tutorial Camera
    public GameObject ARCamera;
    public GameObject SwitchModeToggle;
    public GameObject DescriptionToggle;
    public GameObject AR_Button;
    public GameObject MVR_Button;
    public GameObject ModelSwitch; //Object that represents the current selected model
    public int Manager;

    public void TutorialEnter()
    {
        Cam_3();
        ModelSwitch.SetActive(false);
        DescriptionToggle.SetActive(false);
        if(Manager == 1)
        {
            AR_Button.SetActive(false);
            MVR_Button.SetActive(true);
        }
        else
        {
            AR_Button.SetActive(true);
            MVR_Button.SetActive(false);
        }
    }

    public void TutorialClose()
    {
        SwitchModeToggle.SetActive(true);
        if(Manager == 1)
        {
            Cam_2();
            Manager = 1;
            ModelSwitch.SetActive(true);
            DescriptionToggle.SetActive(true);
        }
        else
        {
            Cam_1();
            Manager = 0;
            ARCamera.SetActive(true);
        }
    }

    public void ChangeCamera()
    {
        ModelSwitch.SetActive(!ModelSwitch.activeSelf);
        GetComponent<Animator>().SetTrigger("Change");
    }

    public void ManageCamera()
    {
        if(Manager == 0)
        {
            Cam_2();
            Manager = 1;
        }
        else
        {
            Cam_1();
            Manager = 0;
        }
    }

    void Cam_1()
    {
        Camera_1.SetActive(true);
        Camera_2.SetActive(false);
        Camera_3.SetActive(false);
        ARCamera.SetActive(true);
    }

    void Cam_2()
    {
        Camera_2.SetActive(true);
        Camera_1.SetActive(false);
        Camera_3.SetActive(false);
        ARCamera.SetActive(false);
    }

    void Cam_3()
    {
        Camera_1.SetActive(false);
        Camera_2.SetActive(false);
        Camera_3.SetActive(true);
        ARCamera.SetActive(false);
        SwitchModeToggle.SetActive(false);
    }
}