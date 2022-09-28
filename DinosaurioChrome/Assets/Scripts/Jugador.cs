using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    private Rigidbody2D rb;

    public float fuerzaSalto = 0;

    public GameManager gameManager;

    bool Salto = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey("space") && Salto == false)
        {
            rb.velocity = new Vector3(0, fuerzaSalto, 0);
            Salto = true;
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Salto = false;

        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            gameManager.GameOver();
        }
    }

    
}
