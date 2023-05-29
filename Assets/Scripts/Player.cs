using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public Animator anim;
    public float speed;
    public float jumpForce;
    private bool isJumping;
    public GameObject bullet;
    public Transform firePoint;
    public int health;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            anim.SetBool("jumping", true);
            isJumping = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            anim.SetBool("jumping", false);
            isJumping = false;
        }
        
    }

    public void OnHit(int dmg)
    {
        health -= dmg;

        if(health <= 0)
        {
            GameController.instance.ShowGameOver();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            anim.SetBool("jumping", true);
            isJumping = true;
        }
    }
}
