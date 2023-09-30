using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{

    // Start is called before the first frame update
    public int destroyEnemies = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        destroyEnemies = 0;
    }

    void DestroyEnemies(){
        destroyEnemies = 1;
    }
}
