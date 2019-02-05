using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class JsonToLevel : MonoBehaviour
{

    string path;
    string jsonString;

    public Transform spawnPos;
    public GameObject playerObject;
    public GameObject deadlyObject;
    public GameObject castleObject;
    public GameObject brickObject;
    private GameObject gameObj;

    public Text levelName;

    public float lowestblock = 0f;
    private float x_offset = 0f;
    public float y_offset = 0f;

    void Start()
    {

        if (ClickedFile.name == null)
        {
            path = Application.streamingAssetsPath + "/data.json";
        }
        else
        {
            path = Application.streamingAssetsPath + "/" + ClickedFile.name;
        }
        jsonString = File.ReadAllText(path);
        Data json = JsonUtility.FromJson<Data>(jsonString);

        levelName.text = json.Level;

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
                else if (letter.ToString() == "P")
                {
                    gameObj = playerObject;
                }
                else if (letter.ToString() == "E")
                {
                    gameObj = deadlyObject;
                }
                else if (letter.ToString() == "C")
                {
                    gameObj = castleObject;
                }
                else if (letter.ToString() == "G")
                {
                    gameObj = brickObject;
                }

                if (gameObj != null)
                {
                    if (spawnPos.position.y - y_offset <= lowestblock)
                    {
                        lowestblock = spawnPos.position.y - y_offset;
                    }

                    Instantiate(gameObj, new Vector2(spawnPos.position.x + x_offset, spawnPos.position.y - y_offset),
                        Quaternion.identity);
                }

                x_offset += 1;
            }

            y_offset += 1;
        }
    }

    //    update the camera position (may or may not change later on)
    void Update()
    {
        if (GameObject.Find("Death Menu").GetComponent<DeathScreen>().dead == false)
        {
            Player player = FindObjectsOfType(typeof(Player))[0] as Player;
            if (!(player.transform.position.y < lowestblock)) transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 2, transform.position.z);
        }
    }

}

[System.Serializable]
public class Data
{
    
    public string Level;
    public List<string> Layers = new List<string>();

}