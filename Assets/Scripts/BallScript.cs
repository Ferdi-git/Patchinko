using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(rb.linearVelocity.x == 0 && rb.linearVelocityY == 0)
        {
            rb.linearVelocity = new Vector2(0.1f, rb.linearVelocity.y);

        }   
    }
}
