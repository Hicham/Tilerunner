using UnityEngine;

[RequireComponent(typeof(Controller2D))]
public class Player : MonoBehaviour
{
    public float jumpHeight = 4;
    public float jumpGravity = .4f;
    private float accelerationTimeAirborne = .2f;
    private float accelerationTimeGrounded = .1f;
    private float moveSpeed = 6;
    
    private float gravity;
    private float jumpVelocity = 8;
    private Vector3 velocity;
    private float velocityXSmoothing;
    
    private Controller2D controller;

    void Start()
    {
        controller = GetComponent<Controller2D>();

        gravity =- (2 * jumpHeight) / Mathf.Pow(jumpGravity, 2);
        jumpVelocity = Mathf.Abs(gravity) * jumpGravity;
        print("Gravity: " + gravity + " Jump velocity: " + jumpVelocity);
    }

    private void Update()
    {
        if (controller.collisions.above || controller.collisions.below)
        {
            velocity.y = 0;
        }
        
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (Input.GetKeyDown(KeyCode.Space) && controller.collisions.below)
        {
            velocity.y = jumpVelocity;
        }
        
        float targetVelocityX = input.x * moveSpeed;
        velocity.x = Mathf.SmoothDamp(velocity.x, targetVelocityX, ref velocityXSmoothing, controller.collisions.below ? accelerationTimeGrounded : accelerationTimeAirborne);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}