using System.Collections.Generic;
using UnityEngine;

public class SpawnEnimies : MonoBehaviour
{
    public List<GameObject> enimies = new List<GameObject>();
    private float timeCount;
    public float spawTime;
    void Start()
    {

    }

   

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        if(timeCount >= spawTime )
        {
            SpawnEnimy();
            timeCount = 0;
        }
    }

    private void SpawnEnimy()
    {
        Instantiate(
            enimies[Random.Range(0, enimies.Count)], 
            transform.position + new Vector3(0, Random.Range(-1f, 2f), 0), 
            transform.rotation);
    }
}
