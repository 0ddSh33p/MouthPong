using UnityEngine;

public class hitter : MonoBehaviour
{
    [SerializeField] private string up, down;
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private float x;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        x = transform.position.x;
    }

    void FixedUpdate()
    {
        transform.position = new Vector2(x, transform.position.y);
        if (Input.GetKey(up)) rb.velocity = new Vector2(0,speed);
        if (Input.GetKey(down)) rb.velocity = new Vector2(0, -speed);

        if (!Input.GetKey(down) && !Input.GetKey(up)) rb.velocity = new Vector2(0, 0);
    }
}
