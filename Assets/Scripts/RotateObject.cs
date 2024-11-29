using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Vector3 rotationVector;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationVector*Time.deltaTime);
    }
}
