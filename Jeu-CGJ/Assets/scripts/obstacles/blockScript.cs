using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class blockScript : MonoBehaviour

{
    private Rigidbody2D rb;
    public float gravity;
    public parametrableScript param;



    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        gravity = rb.gravityScale;
        param = transform.GetComponent<parametrableScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        EventManager.OnNextAction += nextAction;
    }

    void OnDisable()
    {
        EventManager.OnNextAction -= nextAction;

    }

    void nextAction()
    {

        if (param.mode == 0)
        {
            rb.gravityScale *=0f;
            Debug.Log("Pause Objet");

        }

        if(param.mode == 1)
        {
            rb.gravityScale *= 1f;
            Debug.Log("gravité normale ");
        }

        if(param.mode == -1)
        {
            rb.gravityScale *= -1f;
            Debug.Log("gravité inversée ");

        }

    }
}
