using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobBehaviour : MonoBehaviour
{
    public mobMovementScript movemement;
    public parametrableScript param;
    public Rigidbody2D rb;

    public wallHitbox front;
    public wallHitbox back;

    public static mobBehaviour instance;

    void Awake()
    {
        pause();
    }

    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
    }

    public void play()
    {
        front.transform.gameObject.SetActive(true);
        back.transform.gameObject.SetActive(false);

        movemement.speed = 0.05f;
        rb.gravityScale = 1f;
    }

    public void reverse()
    {
        front.transform.gameObject.SetActive(false);
        back.transform.gameObject.SetActive(true);

        movemement.speed = -0.05f;
        rb.gravityScale = 1f;
    }

    public void pause()
    {
        front.transform.gameObject.SetActive(false);
        back.transform.gameObject.SetActive(false);

        movemement.speed = 0f;
        rb.gravityScale = 0f;
        rb.velocity = new Vector3(0, 0, 0);

    }

    

    public void start()
    {
        play();
    }

    public void startAction()
    {
        if(param.mode == 0)
        {
            pause();
        }
        else if(param.mode == -1)
        {
            reverse();
        }
        else
        {
            play();
        }
        
    }

}
