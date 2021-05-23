using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private float spinSpeed = 0.3f;

    Light sun;

    void Start()
    {
        sun = this.GetComponent<Light>();
    }

    void Update()
    {
        this.transform.RotateAround(this.transform.position, Vector3.up, Time.deltaTime * spinSpeed);

    }
}
