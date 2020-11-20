using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TRUE : MonoBehaviour
{
    public int Score; // Очки
    public Text scores; // Очки на экране

    void Update()
    {
        scores.text = Score.ToString();
    }
}
