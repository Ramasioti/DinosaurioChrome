using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public float velocidad;

   

    private void Update()
    {
        transform.position = new Vector2(transform.position.x - velocidad * Time.deltaTime, transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ZoneDeath"))
        {
            Destroy(this.gameObject);
        }
    }
}
