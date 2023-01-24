using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parametrableScript : MonoBehaviour
{
    // 0 = pause, 1 = play, -1 = reverse
    public int mode = 2;

    void OnMouseOver()
    {
        //activer overlay
        if (Input.GetMouseButtonDown(0))
        {
            mode++;
            if (mode == 2)
                mode = -1;


        }

    }




}