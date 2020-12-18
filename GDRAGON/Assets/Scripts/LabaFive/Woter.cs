using System.Collections;
using UnityEngine;

public class Woter : MonoBehaviour
{
    public int i;

    void OnTriggerEnter2D(Collider2D col)
    {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        Gem.scoreCount += i;
        Destroy(gameObject);
    }
}
