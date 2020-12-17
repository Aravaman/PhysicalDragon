using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gradus : MonoBehaviour
{
    private int scoreCount;

    Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreCount = 24;
    }


    void Update()
    {
        scoreText.text = scoreCount + "C";
        if (Gem.scoreCount >= 2)
            scoreCount = 20;
    }
}
