using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gradus : MonoBehaviour
{
    private int scoreCount;
    private int count;
    Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
        StartCoroutine(ExampleCoroutine());
        count = 0;
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(0.0001f);
        scoreCount = RGradus.scoreCount;
    }

    void Update()
    {
        scoreText.text = scoreCount + "C";
        if (count == 0)
            if (Gem.scoreCount >= 2)
            {
                scoreCount = Random.Range(RGradus.scoreCount - 5, RGradus.scoreCount);
                count++;
            }
    }
}
