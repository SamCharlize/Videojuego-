using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject[] powerup = new GameObject[2];
    public GameObject spawnLocation;
    int s;
    
    void Start(){
        s = Random.Range(0, 10);
        if(s < 3){
            s = Random.Range(0, 10);
            if(s < 4){
                Instantiate(powerup[0], spawnLocation.transform.position, spawnLocation.transform.rotation);
            }else{
                Instantiate(powerup[1], spawnLocation.transform.position, spawnLocation.transform.rotation);
            }
        }
    }
}
