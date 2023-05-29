using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnimy : Enemy
{
    private Rigidbody2D rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 5f);
    }

    
    void FixedUpdate()
    {
        rb.velocity = Vector2.left * speed;
    }
}
