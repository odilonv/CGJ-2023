using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionButtonScript : MonoBehaviour
{
    public bool moreButtons;
    public bool overed;
    public GameObject overEffect;
    public numeroSequence numActionsRestantes;

    void OnMouseOver()
    {
        overed = true;
        overEffect.GetComponent<SpriteRenderer>().enabled = true;
        //activer overlay
        if (Input.GetMouseButtonDown(0))
        {
            moreButtons = !moreButtons;
            editManager.editMode = moreButtons;
            
            foreach(Transform child in transform.GetChild(0))
            {
                child.GetComponent<SpriteRenderer>().enabled = moreButtons;
                child.GetComponent<BoxCollider2D>().enabled = moreButtons;
            }
            
        }
            
    }

    void OnMouseExit()
    {
        overed = false;
        overEffect.GetComponent<SpriteRenderer>().enabled = false;
    }


    void Update()
    {
        numActionsRestantes.num = gameManager.nbCoupsRestants;
        
    }

    
}
