using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed= 5f;
    public float moveInputX;
    public float moveInputY;


    private bool Right = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        moveInputX = Input.GetAxis("Horizontal");
        moveInputY = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(moveInputX* speed, moveInputY * speed);
        if(Right==false && moveInputX > 0)
        {
            Flip();
        }else if(Right == true && moveInputX < 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        Right=!Right;
        Vector3 Scaler =transform.localScale;
        Scaler.x *= -1;
        transform.localScale=Scaler;
    }
}
