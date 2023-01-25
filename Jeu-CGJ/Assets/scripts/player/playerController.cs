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

    public Animator anim;

    void Start()
    {
        anim = transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            anim.SetFloat("speed",Mathf.Abs(horizontalMove));
            if(Input.GetButtonDown("Jump"))
            {
                jump = true;
                
                StartCoroutine(jumpCoroutine());
            }
            if(Input.GetButtonDown("NextAction"))
            {
                StartCoroutine(actionCoroutine());
            }
        }
        
        
    }

    IEnumerator actionCoroutine()
    {
        anim.SetBool("action",true);
        yield return new WaitForSeconds(0.3f);
        anim.SetBool("action",false);
    }

    void FixedUpdate ()
    {
        movement.Move(horizontalMove * Time.fixedDeltaTime,jump);
        jump = false;
        
    }


    IEnumerator jumpCoroutine()
    {
        anim.SetBool("jump",true);
        yield return new WaitForSeconds(0.5f);
        anim.SetBool("jump",false);

    }


    public void start()
    {
        canMove = true;
    }
}
