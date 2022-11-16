using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public GameObject spawnPoint3;
    public GameObject spawnPoint4;
    public GameObject prefab;
    private int random;
    private float startDelay = 1.5f;
    private float spawnInterval = 3f;
    void Start()
    { //giving an interval to enemy to spawn after some time
        InvokeRepeating("SpawnObject", startDelay, spawnInterval);
    }


    // giving range to spawn enemies and deactive any random enemy
    void SpawnObject()
    {
       random = Random.Range(1, 5);
        if (random == 1)
        {
            var first = Instantiate(prefab, spawnPoint1.transform.position, prefab.transform.rotation);
            var second = Instantiate(prefab, spawnPoint2.transform.position, prefab.transform.rotation);
            var third = Instantiate(prefab, spawnPoint3.transform.position, prefab.transform.rotation);
            
            Destroy(first);
        }

        if (random == 2)
        {
            var first = Instantiate(prefab, spawnPoint1.transform.position, prefab.transform.rotation);
            var second = Instantiate(prefab, spawnPoint2.transform.position, prefab.transform.rotation);
            var third = Instantiate(prefab, spawnPoint3.transform.position, prefab.transform.rotation);
  
            Destroy(second);
        }

        if (random == 3)
        {
            var first = Instantiate(prefab, spawnPoint1.transform.position, prefab.transform.rotation);
            var second = Instantiate(prefab, spawnPoint2.transform.position, prefab.transform.rotation);
            var third = Instantiate(prefab, spawnPoint3.transform.position, prefab.transform.rotation);
            
            Destroy(third);

        }
        if (random == 4)
        {
            var first = Instantiate(prefab, spawnPoint1.transform.position, prefab.transform.rotation);
            var second = Instantiate(prefab, spawnPoint2.transform.position, prefab.transform.rotation);
            var third = Instantiate(prefab, spawnPoint3.transform.position, prefab.transform.rotation);
            var fourth = Instantiate(prefab, spawnPoint4.transform.position, prefab.transform.rotation);
            
            Destroy(fourth);
        }      

    }
   
}
