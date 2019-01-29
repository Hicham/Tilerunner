using System.Collections;
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
    private GameObject gameObj;

    public Text levelName;

    float x_offset = 0f;
    float y_offset = 0f;

    //float plus1 = 0f;
    //float plus2 = 0f;
    //float plus3 = 0f;
    //float plus4 = 0f;
    //float plus5 = 0f;



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

                if (gameObj != null)
                {
                    Instantiate(gameObj, new Vector2(spawnPos.position.x + x_offset, spawnPos.position.y - y_offset), Quaternion.identity);
                }

                x_offset += 1;
            }

            y_offset += 1;
        }


        //foreach (char letter in json.t1)
        //{
        //    if (letter.ToString() == "0" || letter.ToString() == " ")
        //    {
        //        gameObj = null;
        //    }
        //    else if (letter.ToString() == "1")
        //    {
        //        gameObj = object1;

        //    }
        //    else if (letter.ToString() == "2")
        //    {
        //        gameObj = object2;
        //    }

        //    if (gameObj != null)
        //    {
        //        Instantiate(gameObj, new Vector2(spawnPos.position.x + plus1, spawnPos.position.y - 0), Quaternion.identity);
        //    }

        //    plus1 += 1f;
        //}

        //foreach (char letter in json.t2)
        //{
        //    if (letter.ToString() == "0" || letter.ToString() == " ")
        //    {
        //        gameObj = null;
        //    }
        //    else if (letter.ToString() == "1")
        //    {
        //        gameObj = object1;

        //    }
        //    else if (letter.ToString() == "2")
        //    {
        //        gameObj = object2;
        //    }

        //    if (gameObj != null)
        //    {
        //        Instantiate(gameObj, new Vector2(spawnPos.position.x + plus2, spawnPos.position.y - 1), Quaternion.identity);
        //    }

        //    plus2  += 1f;
        //}

        //foreach (char letter in json.t3)
        //{
        //    if (letter.ToString() == "0" || letter.ToString() == " ")
        //    {
        //        gameObj = null;
        //    }
        //    else if (letter.ToString() == "1")
        //    {
        //        gameObj = object1;

        //    }
        //    else if (letter.ToString() == "2")
        //    {
        //        gameObj = object2;
        //    }

        //    if (gameObj != null)
        //    {
        //        Instantiate(gameObj, new Vector2(spawnPos.position.x + plus3, spawnPos.position.y - 2), Quaternion.identity);
        //    }

        //    plus3 += 1f;
        //}

        //foreach (char letter in json.t4)
        //{
        //    if (letter.ToString() == "0" || letter.ToString() == " ")
        //    {
        //        gameObj = null;
        //    }
        //    else if (letter.ToString() == "1")
        //    {
        //        gameObj = object1;

        //    }
        //    else if (letter.ToString() == "2")
        //    {
        //        gameObj = object2;
        //    }

        //    if (gameObj != null)
        //    {
        //        Instantiate(gameObj, new Vector2(spawnPos.position.x + plus4, spawnPos.position.y - 3), Quaternion.identity);
        //    }

        //    plus4 += 1f;
        //}

        //foreach (char letter in json.t5)
        //{
        //    if (letter.ToString() == "0" || letter.ToString() == " ")
        //    {
        //        gameObj = null;
        //    }
        //    else if (letter.ToString() == "1")
        //    {
        //        gameObj = object1;

        //    }
        //    else if (letter.ToString() == "2")
        //    {
        //        gameObj = object2;
        //    }

        //    if (gameObj != null)
        //    {
        //        Instantiate(gameObj, new Vector2(spawnPos.position.x + plus5, spawnPos.position.y - 4), Quaternion.identity);
        //    }

        //    plus5 += 1f;
        //}

    }

    void Update()
    {


        
    }
}

[System.Serializable]
public class Data
{
    public string Level;
    public List<string> Layers = new List<string>();
    ////public string t1;
    ////public string t2;
    ////public string t3;
    ////public string t4;
    ////public string t5;

}