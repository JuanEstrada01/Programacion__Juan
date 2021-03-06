using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juagador : MonoBehaviour
{
    public int jumpForce;
    public int movementSpeed;
    bool touchFloor = false;



    void Update()
    {
        if (Input.GetKeyDown("space") && touchFloor);
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));


        }
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(movementSpeed, this.GetComponent<Rigidbody2D>().velocity.y);



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        touchFloor = true;
        if (collision.tag == "Obstaculo")
        {
            GameObject.Destroy(this.gameObject);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        touchFloor = false;
    }
}
