
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;


    // Start is called before the first frame update
    void Start()
    {
//        camHeight = Camera.main.orthographicSize * 2;
//        camWidth = Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
//            float targetX = Mathf.Max(levelMinX, Mathf.Min(levelMaxX, target.position.x));

//            float x = Mathf.SmoothDamp(transform.position.x, targetX, ref smoothDampVelocity.x, smoothDampTime);
            
            transform.position = new Vector3(target.position.x,  target.position.y + 2, transform.position.z);
        }
    }
}
