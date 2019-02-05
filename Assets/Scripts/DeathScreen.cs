using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    public bool dead = false;

    public GameObject deathMenuCanvas;
   
    

    void Update()
    {
        if (dead)
        {
            deathMenuCanvas.SetActive(true);
        }
        else
        {
            deathMenuCanvas.SetActive(false);
        }
    }

    public void Respawn()
    {
        Application.LoadLevel("Level");
    }

    public void MainMenu()
    {
        Application.LoadLevel("ShowLevels");
    }
}
