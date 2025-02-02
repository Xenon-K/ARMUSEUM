using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class DescriptionSwitch : MonoBehaviour
{
    public Toggle toggle;
    public GameObject objectToToggle;

    public void oppositeSwitch()
    {

        if (toggle != null)
        {
            objectToToggle.SetActive(!toggle.isOn);
        }
    }

    public void alwaysTrue()
    {

       objectToToggle.SetActive(true);
    }

    public void alwayFalse()
    {
        objectToToggle.SetActive(false);
    }
}
