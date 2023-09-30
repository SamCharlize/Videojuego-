using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour{

    public int contador;
    // Start is called before the first frame update
    void Start(){
        contador = 0;
        
    }
    
    private void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "MrMidnight") {
            contador++;
            }
         }
}
