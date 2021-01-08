using System.Collections;
using UnityEngine;

public class ToFinalThree : MonoBehaviour
{
    public GameObject panelOne;
    public GameObject panelTwo;

    void Update()
    {
        if (Gem.scoreCount >= 13)
            StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(3f);
        if (Gem.scoreCount == 13 || Gem.scoreCount == 15)
            panelTwo.SetActive(true);
        if (Gem.scoreCount == 14)
            panelOne.SetActive(true);
    }
}
