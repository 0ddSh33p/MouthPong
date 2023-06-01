using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    public bool put;
    private Vector3 pos;

    void Start()
    {
        pos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
    }

    void FixedUpdate()
    {
        if(rb.velocity.x > 0) rb.velocity = new Vector2(speed, rb.velocity.y);
        if(rb.velocity.x < 0) rb.velocity = new Vector2(-speed, rb.velocity.y);
        if (rb.velocity.y > 0) rb.velocity = new Vector2(rb.velocity.x, speed);
        if (rb.velocity.y < 0) rb.velocity = new Vector2(rb.velocity.x, -speed);




        if (put) { transform.position = pos; put = false; }
    }
}
