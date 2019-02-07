using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
public class PassVar : MonoBehaviour
{
    public GameObject button;
    public Button butn;

    void Start()
    {
        butn = button.GetComponent<Button>();

        butn.onClick.AddListener(() => Clicker(button.GetComponentInChildren<Text>().text.ToString()));
    }
    

    public void Clicker(string name)
    {
        ClickedFile.name = name + ".json";
        SceneManager.LoadScene("level");
        
    }

}

public class ClickedFile
{
    public static string name = null;
    
    
}
