using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiScript : MonoBehaviour
{
    public void start()
    {
        
        foreach(Transform child in transform.GetChild(0).transform)
        {
            
            if(child.transform.name != "Restart")
            {
                child.gameObject.SetActive(false);
            }
            
        }
        
    }
}
