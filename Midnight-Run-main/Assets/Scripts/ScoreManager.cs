using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText ;
    public int score;
    
    private void Awake () {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
       score = 0;
       scoreText.text = "Puntos:" + score.ToString(); 
    }

    // Update is called once per frame
    public void addPoint()
    { 
        score += 1;
        scoreText.text = "Puntos:" + score.ToString(); 
        
    }
}
