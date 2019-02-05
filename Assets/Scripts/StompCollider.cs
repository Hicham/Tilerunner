using UnityEngine;

/**
 * This is being used in the head of an enemy. (for example, the Goombo head)
 */
public class StompCollider : MonoBehaviour
{

    private Rigidbody2D rigidbody2;

    private void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("test");
            Destroy(gameObject.transform.parent.gameObject);
            
//            Player player = other.gameObject.GetComponent<Player>();
//
//            player.playerState = Player.PlayerState.jumping;
//            player.velocity = new Vector2(player.velocity.x, 6);
        }
    }
}