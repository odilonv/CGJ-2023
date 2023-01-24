using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class editManager : MonoBehaviour
{
    public static int editState;
    public static bool editMode;

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
        editState = -2;
        editMode = false;
    }
}
