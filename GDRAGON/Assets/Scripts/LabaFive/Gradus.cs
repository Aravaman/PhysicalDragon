﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gradus : MonoBehaviour
{
    public int scoreCount;
    private int count;
    public int gradus;
    public int score; 
    Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
        count = 0;
    }

    void Update()
    {
        scoreText.text = scoreCount + "C";
        if (count == 0)
            if (Gem.scoreCount >= score)
            {
                scoreCount = gradus;
                count++;
            }
    }
}
