using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Offsets.iScore = Convert.ToInt32((Time.timeSinceLevelLoad * 10));
        if (Offsets.bGameStatus)
        {
            score.text = "Score: " + Offsets.iScore.ToString();
        }
        else {
            Offsets.iScore = 0;
            score.text = "GAME OVER";
        }
    }
}
