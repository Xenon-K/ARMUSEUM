using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class ImageRotate : MonoBehaviour
{
    //public Toggle toggle;
    public GameObject objectToToggle;
    public Image image;

    // Method to rotate the image by 180 degrees
    public void RotateBy180Degrees()
    {
        if (!objectToToggle.activeSelf)
        {
            // Set rotation to 180 degrees around the z-axis
            image.rectTransform.rotation = Quaternion.Euler(0f, 0f, 180f);
        }
        else
        {
            // Set rotation to 0 degrees around the z-axis
            image.rectTransform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
}
