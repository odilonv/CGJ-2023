using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parametrableScript : MonoBehaviour
{
    // 0 = pause, 1 = play, -1 = reverse, -2 rien
    public int mode = -2;
    public bool overed;

    public numeroSequence num;

    void OnMouseOver()
    {
        if(editManager.editMode)
        {
            overed = true;
            if (Input.GetMouseButtonDown(0))
            {
                
                if(mode == editManager.editState)
                {
                    gameManager.nbCoupsRestants ++;
                    num.GetComponent<SpriteRenderer>().enabled = false;
                    mode = -2;
                }
                else if(gameManager.nbCoupsRestants > 0)
                {
                    
                    if(mode == -2)
                    {
                        gameManager.nbCoupsRestants --;
                    }
                    num.GetComponent<SpriteRenderer>().enabled = true;
                    num.num = gameManager.nbCoups - gameManager.nbCoupsRestants ;
            
                    mode = editManager.editState;
                }
                
            }
        }
        
        //activer overlay
        
            
    }

    void OnMouseExit()
    {
        overed = false;
    }

    public void action()
    {
        if(transform.GetComponent<mobBehaviour>() != null)
        {
            transform.GetComponent<mobBehaviour>().startAction();
            Debug.Log("action");
        }
        else if(transform.GetComponent<blockBehaviour>() != null)
        {
            transform.GetComponent<blockBehaviour>().startAction();
        }
    }


    
    
}
