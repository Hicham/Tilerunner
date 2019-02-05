using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickEvents : MonoBehaviour
{
    private void OnMouseDown()
    {
        Play();
    }

    public void Play()
    {
        Debug.Log(this.GetComponentInChildren<Text>().text);   
//        Application.LoadLevel("Level");
    }
    
}
