using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiScript : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.OnLevelStart += start;
    }

    void onDisable()
    {
        EventManager.OnLevelStart -= start;
    }

    void start()
    {
        transform.gameObject.SetActive(false);
    }
}
