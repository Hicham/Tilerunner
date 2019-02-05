using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class ScanFiles : MonoBehaviour {

    string path;
    public GameObject button;
    public offset offset = new offset();
    public static FileInfo[] info;
    int counter = 0;

    void Start()
    {
        
        path = Application.streamingAssetsPath;
        DirectoryInfo dir = new DirectoryInfo(path);
        info = dir.GetFiles("*.json");
        

        foreach (FileInfo f in info)
        {
            
            button.GetComponentInChildren<Text>().text = f.Name.Replace(".json", "");


            Instantiate(button, new Vector2(200 + offset.x, 400 + offset.y), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);

            offset.counter++;
            offset.x += 200;

            if (offset.counter > 3)
            {
                offset.x = 0;
                offset.y -= 100;
                offset.counter = 0;
            }
            

        }

    }
    void Update()
    {
        
    }
}

public class offset
{
    public float x = 0;
    public float y = 0;
    public int counter;
}
