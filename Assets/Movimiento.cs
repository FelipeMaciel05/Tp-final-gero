using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float subida;
    float a;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.1f, 0, 0);
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(0, 0, 2);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(0, 0, -2);
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            if(a < 0.51)
            {
                rb.AddForce(Vector3.up * subida, ForceMode.Impulse);
            }
        }
        a = transform.position.y;
    }
}
