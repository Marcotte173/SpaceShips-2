using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateShield : MonoBehaviour
{
    bool on;
    public GameObject shield;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && on) on = false;
        else if (Input.GetKeyDown(KeyCode.Space) && on == false) on = true;
        if (on) shield.SetActive(true);
        else shield.SetActive(false);
    }
}
