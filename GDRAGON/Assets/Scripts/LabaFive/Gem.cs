using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gem : MonoBehaviour
{
    public static int scoreCount;

    Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreCount = 0;
    }


    void Update()
    {
        scoreText.text = "" + scoreCount;
    }
}
