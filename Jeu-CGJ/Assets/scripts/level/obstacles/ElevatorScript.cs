using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{

    public parametrableScript param;

    public Animator anim;

    //public Collider2D col;
    void Start()
    {
        anim = transform.GetComponent<Animator>();
    }


    
    // Update is called once per frame
    void Update()
    {
        
        if(!EventManager.levelStarted || mode == 0)
        {
            anim.SetInteger("OnOff",0);
        }
        else if((mode == 1 || mode == -2))
        {
            anim.SetInteger("OnOff",1);
        }
        
        
    }


    public int mode = -2;
    void OnTriggerStay2D(Collider2D col)
    {
        
        if(mode == -1)
        {
            if(col.gameObject.GetComponent<Rigidbody2D>() != null)
            {
                col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * -50);
            }
        }
        else if(mode == 1 || mode == -2 )
        {
            if(col.gameObject.GetComponent<Rigidbody2D>() != null)
            {
                col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 30);  
            }
        }
        else
        {
            if(col.GetComponent<blockBehaviour>() != null)
            {
                col.transform.position -= new Vector3(0f,0.00001f,0f);
            }
        }
  
    }

    




    public void start()
    {
        
    }


    public void startAction()
    {

    }




}
