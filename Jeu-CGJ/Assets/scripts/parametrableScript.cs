using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parametrableScript : MonoBehaviour
{
    // 0 = pause, 1 = play, -1 = reverse, -2 rien
    public int mode = -2;
    public bool overed;

    void OnMouseOver()
    {
        if(editManager.editMode)
        {
            overed = true;
            if (Input.GetMouseButtonDown(0))
            {
                if(mode == editManager.editState)
                {
                    mode = -2;
                }
                else
                {
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


    
    
}
