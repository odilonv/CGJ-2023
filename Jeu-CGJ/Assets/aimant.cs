using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimant : MonoBehaviour
{
    public void aimanter()
    {
        transform.position = new Vector3(transform.position.x,Mathf.Round(transform.position.y),0);
    }
}
