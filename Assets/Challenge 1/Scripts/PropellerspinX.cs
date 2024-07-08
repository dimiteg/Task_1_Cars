using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerspinX : MonoBehaviour
{
    public float spinSpeed = 20f;
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * spinSpeed);
    }
}
