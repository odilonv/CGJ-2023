using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overlayScript : MonoBehaviour
{
    public parametrableScript param;

    void Start()
    {
        //param = transform.parent.GetComponent<parametrableScript>();
    }

    void Update()
    {
        foreach (Transform Child in transform) 
        {
            Child.GetComponent<SpriteRenderer>().enabled = param.overed;
        }
    }
}
