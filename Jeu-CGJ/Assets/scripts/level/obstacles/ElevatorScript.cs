using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{

    public parametrableScript param;


    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        start(collision);
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        start(collision);  
        
    }


    public void play(Collider2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 30);
    }

    public void pause(Collider2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up *0);
    }


    public void reverse(Collider2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * -50);
    }




    public void start(Collider2D collision)
    {
        if (param.mode == -2)
        {
            play(collision);
        }

    }


    public void startAction(Collider2D collision)
    {
        if (param.mode == 0)
        {
            pause(collision);
        }
        else if (param.mode == -1)
        {
            reverse(collision);
        }
        else
        {
            play(collision);
        }


    }




}
