using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalScript : MonoBehaviour
{
    public int nextLevel;

    void Start()
    {
        StartCoroutine(animateGoal());
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "player")
        {
            SceneManager.LoadScene(nextLevel);
        }
    }

    public GameObject spirale;
    IEnumerator animateGoal()
    {
        int d = 0;
        while(true)
        {
            
            if(EventManager.levelStarted)
            {
                d = (d-90)%360;
                spirale.transform.rotation = Quaternion.Euler(0f, 0f,d);
            }
            
            yield return new WaitForSeconds(0.3f);
        }
        
    }
}
