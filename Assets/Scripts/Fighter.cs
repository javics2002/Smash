using UnityEngine;

public abstract class Fighter : MonoBehaviour
{
    float damage;
    float horizontalForce;
    float jumpForce;
    float lx, ly;
    float speed;
    float maxSpeed;
    Rigidbody2D rb;

    protected void Start()
    {
        damage = 0.00f;
        rb = GetComponent<Rigidbody2D>();
    }

    protected void Update()
    {
        lx = Input.GetAxis("Horizontal");
        ly = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Attack"))
            Attack(lx, ly);
    }

    protected void FixedUpdate()
    {
        if(rb.velocity.x > maxSpeed)
            rb.AddForce(new Vector2(lx, 0) * speed);
    }

    protected abstract void Attack(float x, float y);

    protected abstract void Smash(float x, float y);

    protected abstract void Jump(float x, float y);

    protected abstract void Shield(float x, float y);

    protected abstract void Grab(float x, float y);
}
