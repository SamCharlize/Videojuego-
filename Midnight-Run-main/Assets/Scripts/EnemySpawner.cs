using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    public GameObject enemy;
    public int rotation;
    public GameObject spawnLocation;
    int s;

    void Start()
    {
        s = Random.Range(0, 100);
        if(s >= 25){
            Instantiate(enemy, spawnLocation.transform.position, spawnLocation.transform.rotation);
        }
    }
}
