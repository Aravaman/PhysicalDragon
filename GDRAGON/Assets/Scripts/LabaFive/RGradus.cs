using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RGradus : MonoBehaviour
{
    public static int scoreCount;
    Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreCount = Random.Range(20, 25);
        scoreText.text = scoreCount + "C";
    }
}
