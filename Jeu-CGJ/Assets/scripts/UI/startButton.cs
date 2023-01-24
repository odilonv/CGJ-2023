using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startButton : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = transform.GetComponent<Animator>();
        animator.SetInteger("pressed",0);
    }

    void Update()
    {
        transform.GetComponent<SpriteRenderer>().enabled = ( !EventManager.levelStarted);
    }

    bool animationEnded = true;
    void OnMouseOver()
    {
        if(animationEnded)
        {
            animator.SetInteger("pressed",1);
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            animationEnded = false;
            animator.SetInteger("pressed",2);
            StartCoroutine(unclickButton());
        }
    }

    void OnMouseExit()
    {
        animator.SetInteger("pressed",0);
    }

    public EventManager eventM;

    IEnumerator unclickButton()
    {
        yield return new WaitForSeconds(0.3f);
        animator.SetInteger("pressed",2);

        yield return new WaitForSeconds(0.1f);
        eventM.startLevel();
        animationEnded = true;
       
    }
}
