using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemiesPlatform : MonoBehaviour
{
    public GameObject enemy;
    public List<Transform> points;

    private GameObject currentEnemy;

    void Start()
    {
        CreateEnemy();
    }

    void Update()
    {
        
    }

    public void Spawn()
    {
        if (currentEnemy == null)
        {
            CreateEnemy();
        }
    }

    void CreateEnemy()
    {
        int pos = Random.Range(0, points.Count);
        GameObject e = Instantiate(enemy, points[pos].position, points[pos].rotation);
    }
}
