using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEditor;

public class MenuLevelClick : MonoBehaviour
{
    public GameObject button;
    public Button butn;

    void Start()
    {
        butn = button.GetComponent<Button>();

        butn.onClick.AddListener(() => Clicker(button.GetComponentInChildren<Text>().text, PlayerPrefs.GetString("Path")));
    }
    

    public void Clicker(string name, string path)
    {
        ClickedFile.name = name + ".json";
        ClickedFile.path = path;
        SceneManager.LoadScene("level");
        
    }


}

public class ClickedFile
{
    public static string name = null;
    public static string path = null;
}
