using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    void Update()
    {
        speed += (float).1 * Time.deltaTime;
        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Player"){
            Destroy(collision.gameObject);
        }
    }
}
