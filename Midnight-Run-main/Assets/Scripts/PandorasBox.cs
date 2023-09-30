using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PandorasBox : MonoBehaviour
{

    public GameObject objectManager;
    public GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        //objectManager = GameObject.Find("ObjectManager");
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            foreach (var enem in enemies){
                Destroy(enem);
            }
            Destroy(this.gameObject);
        }
    }
}
