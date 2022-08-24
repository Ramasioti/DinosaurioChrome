using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    private Rigidbody2D rb;  

    bool Salto = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey("space") && Salto == false)
        {
            rb.velocity = new Vector3(0, 5, 0);
            Salto = true;
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Salto = false;
    }
}
