using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spam : MonoBehaviour
{
    public GameObject prefab;
    GameObject clon;
    bool Choque;
    int cuenta;
    // Start is called before the first frame update
    void Start()
    {
        Choque = false;
        cuenta = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Choque == true && cuenta < 30)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                clon = Instantiate(prefab);
                clon.transform.position = transform.position - new Vector3(-0.5f, 0, 0);
                cuenta += 1;
            }
        }
        if(cuenta == 30)
        {
            transform.position = new Vector3(99, 0.5f, 0);
        }
    }
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Spam")
        {
            Choque = true;
        }
    }
}
