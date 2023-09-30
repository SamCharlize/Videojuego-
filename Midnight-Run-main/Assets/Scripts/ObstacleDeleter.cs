using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDeleter : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Obstaculo"){
            Destroy(collision.gameObject);
        }
    }
}
