using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;
    public int movementForce = 1000;
    public float bodyDelay = 2;

    void FixedUpdate() {

        if (Input.GetKey("a")) {
            left();
        }

        if (Input.GetKey("d"))
        {
            right();
        }

    }

    void left() {
        rb.AddForce(-movementForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    void right() {
        rb.AddForce(movementForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }


    private void Invoke(object v1, int v2)
    {
        throw new NotImplementedException();
    }
}
