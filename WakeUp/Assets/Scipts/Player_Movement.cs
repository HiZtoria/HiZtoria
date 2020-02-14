using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public int playerSpeed = 10;
    private bool facingRight = false;
    public int jumpPower = 1250;
    private float moveX;

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
       
    }


    void PlayerMove()
    {
        //Controls
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump")) {
            Jump();
        }
        //Animations
        //direction
        if (moveX < 0.0f && facingRight == false) {
            FlipPlayer();
        } else if (moveX > 0.0f && facingRight == true) {
            FlipPlayer();
        }
        //p6
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpPower);
    }

    void FlipPlayer() 
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;

    }

}
