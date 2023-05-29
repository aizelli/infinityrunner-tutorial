using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Player player;
    public int healf;
    public int damage;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    public virtual void AplayDamage(int dmg)
    {
        healf -= dmg;

        if(healf < 0)
        {
            Destroy(gameObject);
        }
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet")) 
        { 
            AplayDamage(collision.GetComponent<Projectile>().damage);
        }

        if (collision.CompareTag("Player"))
        {
            player.OnHit(damage);
        }

    }
}
