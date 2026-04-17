using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = 0f;
        movement.y = 0f;

        if (Input.GetKey(KeyCode.A))
            movement.x = -1f;
        if (Input.GetKey(KeyCode.D))
            movement.x = 1f;
        if (Input.GetKey(KeyCode.W))
            movement.y = 1f;
        if (Input.GetKey(KeyCode.S))
            movement.y = -1f;

        movement = movement.normalized;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}