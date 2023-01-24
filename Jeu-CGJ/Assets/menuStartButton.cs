using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuStartButton : MonoBehaviour
{
    public bool overed = false;
    void OnMouseOver()
    {
        overed = true;
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(1);
        }
    }

    void OnMouseExit()
    {
        overed = false;
    }
}
