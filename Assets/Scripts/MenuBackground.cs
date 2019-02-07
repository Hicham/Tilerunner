using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBackground : MonoBehaviour {

    public GameObject brick;
    public GameObject enemy;
    public GameObject question;
    public GameObject castle;
    private GameObject obj;

    int currentLayer;
    float offset;

    private GameObject mover;
    private Vector2 targetPos;
    bool direction = true;
    
    

    void Start ()
    {
        List<string> layers = new List<string>();
        string l4 = "003000000000000000";
        string l3 = "000000000000000000";
        string l2 = "000000000020004000";
        string l1 = "111111111111111111";

        
        layers.Add(l1);
        layers.Add(l2);
        layers.Add(l3);
        layers.Add(l4);

        foreach (string layer in layers)
        {
            offset = 0;
            foreach (char tile in layer)
            {
                
                

                if(tile.ToString() == "0")
                {
                    obj = null;
                }

                if (tile.ToString() == "1")
                {
                    obj = brick;
                }

                if (tile.ToString() == "2")
                {
                    obj = enemy;
                }

                if (tile.ToString() == "3")
                {
                    obj = question;  
                }

                if (tile.ToString() == "4")
                {
                    obj = castle;
                }



                if (obj != null)
                {
                    Instantiate(obj, new Vector2(-8.5f + offset , -4.5f + currentLayer), Quaternion.identity);
                }
                offset += 1;
                
            }

            currentLayer += 1;
        }
        mover = GameObject.FindGameObjectWithTag("Enemy");
    }
	
	void Update ()
    {
        if (mover.transform.position.x > 8 || mover.transform.position.x < -8) {
            direction = !direction;         
        }

        

        if (direction == true)
        {
            targetPos = new Vector2(mover.transform.position.x + 0.05f, mover.transform.position.y);
        }

        if (direction == false)
        {
            targetPos = new Vector2(mover.transform.position.x + -0.05f, mover.transform.position.y);
        }
        mover.transform.position = targetPos;
	}
}
