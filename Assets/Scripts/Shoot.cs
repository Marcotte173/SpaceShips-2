using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject laser;

    private void Start()
    {
        laser = Instantiate(laser, firePoint.position, Quaternion.identity);
        laser.SetActive(false);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            laser.SetActive(true);
            laser.transform.position = firePoint.position;
        }
    }
}
