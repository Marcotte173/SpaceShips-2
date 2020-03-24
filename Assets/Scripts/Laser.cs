using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float damage;
    public float speed;
    float timer = 1;
    Transform sightsTarget;
    public GameObject sights;

    private void Start()
    {
        sightsTarget = sights.GetComponent<Transform>();
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = 1;
            gameObject.SetActive(false);
        }
        transform.position = Vector2.MoveTowards(transform.position, sightsTarget.position, speed * Time.deltaTime);
    }
}
