using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public float power;
    public float integrity;
    

    private void TakeDamage(float damage)
    {
        integrity -= damage;
        integrity = (integrity <= 0) ? 0 : integrity;
        if (integrity == 0) gameObject.SetActive(false);
        Debug.Log("Kaboom");
    }
}
