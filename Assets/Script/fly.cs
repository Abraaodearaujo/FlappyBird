using UnityEngine;

public class fly : MonoBehaviour
{
    public float flyForce;
    private Rigidbody2D rb2d;
    public GamerOver game;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        FLY();
    }

    void FLY()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2d.linearVelocity = Vector2.up * flyForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        game.GameOverActive();
    }
}
