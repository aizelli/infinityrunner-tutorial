using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombEnemy : Enemy
{
    public GameObject bomb;
    public Transform firePoint;

    public float throwTime;
    private float throwCount;

    void Start()
    {
        
    }

    void Update()
    {
        throwCount += Time.deltaTime;

        if(throwCount >= throwTime) 
        {
            Instantiate(bomb, firePoint.position, firePoint.rotation);
            throwCount = 0;
        }
    }
}
