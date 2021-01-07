using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalFive : MonoBehaviour
{
    public Image im;
    public int trueFalse;
    public GameObject panelOne;
    public GameObject panelTwo;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (Gem.scoreCount >= 5)
        {
            Gem.scoreCount += trueFalse;
            im.sprite = Resources.Load<Sprite>("6");
        }
    }

    void Update()
    {
        if (Gem.scoreCount >= 7)
            StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(3f);
        if (Gem.scoreCount == 7 || Gem.scoreCount == 8)
            panelTwo.SetActive(true);
        if (Gem.scoreCount == 9)
            panelOne.SetActive(true);
    }
}
