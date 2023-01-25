using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numeroSequence : MonoBehaviour
{
    Animator animator; 
    
    public int num = 0;

    void Start()
    {
        animator = transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("numSequence",num);
        
    }
}
