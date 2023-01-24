using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour
{
    public actionButtonScript parentButton;
    public bool overed;
    public int state;

    void Start()
    {
        parentButton = transform.parent.transform.parent.GetComponent<actionButtonScript>();
    }

    void OnMouseOver()
    {
        overed = true;
        //activer overlay
        if (Input.GetMouseButtonDown(0)
        && parentButton.moreButtons)
        {
            editManager.editState = state;
           
        }
            
    }

    void OnMouseExit()
    {
        overed = false;
    }
}
