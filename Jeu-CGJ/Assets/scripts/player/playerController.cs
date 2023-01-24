using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public playerMovement movement;

    float horizontalMove = 0f;

    public float runSpeed = 40f;

    private bool jump = false;

    private bool canMove = false;

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            if(Input.GetButtonDown("Jump"))
            {
                jump = true;
            }
        }
        
    }

    void FixedUpdate ()
    {
        movement.Move(horizontalMove * Time.fixedDeltaTime,jump);
        jump = false;
    }


    public void start()
    {
        canMove = true;
    }
}
