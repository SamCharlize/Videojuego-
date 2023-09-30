using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public Text scoreText ;
    public int score;
    
    // Start is called before the first frame update
    void Start()
    {
       score = 0;
       scoreText.text = "Puntos:" + score.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
