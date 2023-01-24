using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class editManager : MonoBehaviour
{
    public static int editState;
    public static bool editMode;


    public void start()
    {
        editState = -2;
        editMode = false;
    }
}
