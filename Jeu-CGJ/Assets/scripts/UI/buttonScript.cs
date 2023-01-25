using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour
{
    public actionButtonScript parentButton;
    public bool overed;
    public GameObject overEffect;
    public int state;
    public bool selected = false;

    void Start()
    {
        parentButton = transform.parent.transform.parent.GetComponent<actionButtonScript>();
    }

    void OnMouseOver()
    {
        if(parentButton.moreButtons)
        {
            overed = true;
            overEffect.GetComponent<SpriteRenderer>().enabled = true;
            if (Input.GetMouseButtonDown(0))
            {
                editManager.editState = state;
                selected = !selected;
            }
        }
        
        //activer overlay
        
            
    }

    void OnMouseExit()
    {
        if(!selected)
        {
            overed = false;
            overEffect.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    void Update()
    {
        if(editManager.editState != state || !parentButton.moreButtons)
        {
            selected = false;
            overed = false;
            overEffect.GetComponent<SpriteRenderer>().enabled = false;
            
        }
    }
}
