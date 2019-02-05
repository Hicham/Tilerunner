using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class JsonToLevel : MonoBehaviour {
    
    string path;
    string jsonString;

    public Transform spawnPos;
    public GameObject object1; 
    public GameObject object2;
    public GameObject deadlyObject;
    private GameObject gameObj;

    public Text levelName;

    private float x_offset = 0f;
    private float y_offset = 0f;

    void Start()
    {

        path = Application.streamingAssetsPath + "/data.json";
        jsonString = File.ReadAllText(path);
        Data json = JsonUtility.FromJson<Data>(jsonString);

        levelName.text = json.Level.ToString();

        GenerateLevel(json);
    }

    void GenerateLevel(Data json)
    {
        foreach (string layer in json.Layers)
        {
            x_offset = 0f;

            foreach (char letter in layer)
            {
                if (letter.ToString() == "A")
                {
                    gameObj = null;
                }
                else if (letter.ToString() == "G")
                {
                    gameObj = object1;
                }
                else if (letter.ToString() == "P")
                {
                    gameObj = object2;
                }
                else if (letter.ToString() == "E")
                {
                    gameObj = deadlyObject;
                }
                if (gameObj != null)
                {
                    Instantiate(gameObj, new Vector2(spawnPos.position.x + x_offset, spawnPos.position.y - y_offset), Quaternion.identity);
                }

                x_offset += 1;
            }

            y_offset += 1;
        }
    }

    //    update the camera position (may or may not change later on)
    void Update()
    {
        Player player = FindObjectsOfType(typeof(Player))[0] as Player;    //    getting the player object, directly.
        //    transform.position = the camera position
        transform.position = new Vector3(player.transform.position.x,  player.transform.position.y + 2, transform.position.z);
    }
}

[System.Serializable]
public class Data
{
    
    public string Level;
    public List<string> Layers = new List<string>();

}