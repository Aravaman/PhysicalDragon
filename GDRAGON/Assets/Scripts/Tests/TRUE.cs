using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TRUE : MonoBehaviour
{
    public int Score; // Очки
    public Text score; // Очки на экране

    void Update()
    {
        score.text = Score.ToString();
    }
}
