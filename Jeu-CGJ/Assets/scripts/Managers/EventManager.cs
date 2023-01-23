using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour
{
    

    public delegate void NextAction();
    public static event NextAction OnNextAction; 

    void Update()
    {
        if(Input.GetButtonDown("NextAction"))
        {
            nextAction();    
        } 
    }

    public void nextAction()
    {
        if(OnNextAction != null)
        {
            OnNextAction();
        }
        
    }
}
