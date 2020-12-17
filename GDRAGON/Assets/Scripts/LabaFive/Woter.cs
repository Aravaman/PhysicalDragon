using System.Collections;
using UnityEngine;

public class Woter : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        Gem.scoreCount += 1;
        Destroy(gameObject);
    }
}
