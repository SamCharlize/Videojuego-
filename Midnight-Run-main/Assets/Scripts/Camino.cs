using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camino : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;

    // Update is called once per frame
    void Update()
    {
        speed += (float).1 * Time.deltaTime;
        this.transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
