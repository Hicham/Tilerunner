using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{

    public string respawn;

    public string mainmenu;

    public GameObject deathMenuCanvas;
   
    

    void Update()
    {
        
    }

    public void Respawn()
    {
        Application.LoadLevel("Level");
    }

    public void MainMenu()
    {
        Application.LoadLevel("GameOver");
    }
}
