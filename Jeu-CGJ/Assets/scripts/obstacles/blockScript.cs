using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float gravity;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        gravity = rb.gravityScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void nextAction()
    {
        rb.gravityScale *= -1f;
    }
}
