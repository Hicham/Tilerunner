using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MenuLevelScanner : MonoBehaviour {

    string path;
    public Button butn;
    public GameObject button;
    public static FileInfo[] info;
    int counter = 0;

    void Start()
    {
        path = PlayerPrefs.GetString("Path");
        if (path.Equals("") || path == null)
        {
            path = EditorUtility.OpenFolderPanel("Load json levels", "", "");
            PlayerPrefs.SetString("Path", path);
            PlayerPrefs.Save();
        }
        DirectoryInfo dir = new DirectoryInfo(PlayerPrefs.GetString("Path"));
        info = dir.GetFiles("*.json");
        

        foreach (FileInfo f in info)
        {
            button.GetComponentInChildren<Text>().text = f.Name.Replace(".json", "");

            Instantiate(button, new Vector2(), Quaternion.identity, GameObject.FindGameObjectWithTag("Content").transform);
        }
        
        butn.onClick.AddListener(() => ChangeDirectory());

    }
    public void ChangeDirectory()
    {
        string path = EditorUtility.OpenFolderPanel("Load json levels", "", "");
        PlayerPrefs.SetString("Path", path);
        PlayerPrefs.Save();
		Application.LoadLevel("ShowLevels");
    }
}

