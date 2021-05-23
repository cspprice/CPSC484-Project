using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    [SerializeField]
    private new GameObject light;

    private float timer = 0;
    private bool on = true;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1)
        {
            timer = 0;
            if(on)
            {
                light.SetActive(false);
                on = false;
            }
            else
            {
                light.SetActive(true);
                on = true;
            }
        }

    }
}
