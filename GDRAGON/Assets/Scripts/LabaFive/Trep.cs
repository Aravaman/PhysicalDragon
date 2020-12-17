using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trep : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (Gem.scoreCount == 1)
        {
            Destroy(gameObject);
            Gem.scoreCount += 1;
        }
    }
}
