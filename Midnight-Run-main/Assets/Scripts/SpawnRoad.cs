using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRoad : MonoBehaviour
{
    
    public GameObject road;
    public Transform spawn;
    public Transform director;

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player")
            Instantiate(road, spawn.position, director.rotation);
    }

}
