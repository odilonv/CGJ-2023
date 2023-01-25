using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour
{
    void Start()
    {
        levelStarted = false;
        
    }

    public int i = 1;
    void Update()
    {
        if(Input.GetButtonDown("NextAction")
        && (i != (gameManager.nbCoups - gameManager.nbCoupsRestants)+1)
        && levelStarted)
        {
            nextAction();    
        } 
    }

    public parametrableScript[] parametrables;
    public void nextAction()
    {
        foreach(parametrableScript p in parametrables)
        {
            if(p.num.num == i)
            {
                p.action();
            }
        }
        i++;
    }

    


    public static bool levelStarted = false;

    public mobBehaviour[] mobListe;
    public blockBehaviour[] blockListe;
    public ElevatorScript[] fanListe;
    public int t;
    public playerController player;
    public uiScript ui;
    public editManager edit;
    public void startLevel()
    {
        levelStarted = true;
        foreach (mobBehaviour m in mobListe)
        {
            if(m != null)
            {
                levelStarted = true;
                m.start();
            }
            
        }

        foreach (blockBehaviour b in blockListe)
        {
            if(b != null)
            {
                b.start();
            }
        }

        foreach (ElevatorScript e in fanListe)
        {
            if(e != null)
            {
                e.start();
            }
        }

        player.start();

        ui.start();

        edit.start();
        
    }





}
