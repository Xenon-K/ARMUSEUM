using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Update is called once per frame
    public void UpdateState()
    {
        if (GetComponent<Animator>().GetBool("State") == true)
            GetComponent<Animator>().SetBool("State", false);
        else
            GetComponent<Animator>().SetBool("State", true);
        //GetComponent<Animator>().SetInteger("State", GetComponent<Animator>().GetInteger("State")+1);
    }
    public void OnMouseUpAsButton()
    {
        if (GetComponent<Animator>().GetBool("State") == true)
            GetComponent<Animator>().SetBool("State", false);
        else
            GetComponent<Animator>().SetBool("State", true);
    }
}
