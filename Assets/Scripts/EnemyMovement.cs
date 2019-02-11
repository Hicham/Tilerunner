using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private Vector2 startPos;
    private Vector2 targetPos;
    bool direction = true;
    
    private void Start()
    {
        startPos = new Vector2(transform.position.x, transform.position.y);
    }
    
    private void Update()
    {
        if (Vector2.Distance(transform.position, startPos) > 1.3 || Vector2.Distance(transform.position, startPos) < -1.3) {
            direction = !direction;
        }

        if (direction)
        {
            targetPos = new Vector2(transform.position.x + 0.05f, transform.position.y);
        }

        if (!direction)
        {
            targetPos = new Vector2(transform.position.x + -0.05f, transform.position.y);
        }
        transform.position = targetPos;
    }

}
