using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToFinalFour : MonoBehaviour
{
    public Image im;
    public GameObject panelOne;
    public GameObject panelTwo;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (Gem.scoreCount >= 30)
        {
            if (Gem.scoreCount == 40)
                im.sprite = Resources.Load<Sprite>("10");
            if (Gem.scoreCount == 50)
                im.sprite = Resources.Load<Sprite>("20");
            if (Gem.scoreCount == 60)
                im.sprite = Resources.Load<Sprite>("30");
        }
    }

    void Update()
    {
        if (Gem.scoreCount >= 40)
            StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(3f);
        if (Gem.scoreCount == 60 || Gem.scoreCount == 50)
            panelTwo.SetActive(true);
        if (Gem.scoreCount == 40)
            panelOne.SetActive(true);
    }
}
