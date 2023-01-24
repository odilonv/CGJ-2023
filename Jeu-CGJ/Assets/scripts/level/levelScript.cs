using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelScript : MonoBehaviour
{
    public int nbCoups;
    void Awake()
    {
        gameManager.nbCoups = nbCoups;
        gameManager.nbCoupsRestants = nbCoups;
        gameManager.etapesequence = 0;
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

  


}
