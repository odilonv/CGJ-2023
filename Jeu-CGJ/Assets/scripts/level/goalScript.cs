using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalScript : MonoBehaviour
{
    public int nextLevel;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "player")
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
