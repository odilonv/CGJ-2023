using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stateDisplayScript : MonoBehaviour
{
    public parametrableScript param;

    void Start()
    {
        //param = transform.parent.GetComponent<parametrableScript>();
    }

    void Update(){
        foreach (Transform Child in transform) 
        {
            Child.GetComponent<SpriteRenderer>().enabled = false;
        }
        if(param.mode != -2)
        {
            transform.GetChild(param.mode+1).GetComponent<SpriteRenderer>().enabled = true;
        }
        
        
    }
}
