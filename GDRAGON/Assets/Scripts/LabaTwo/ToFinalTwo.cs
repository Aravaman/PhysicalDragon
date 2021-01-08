using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToFinalTwo : MonoBehaviour
{
    public Image im;
    public GameObject panelOne;
    public GameObject panelTwo;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (Gem.scoreCount >= 300)
        {
            if (Gem.scoreCount == 400)
                im.sprite = Resources.Load<Sprite>("100");
            if (Gem.scoreCount == 500)
                im.sprite = Resources.Load<Sprite>("200");
            if (Gem.scoreCount == 600)
                im.sprite = Resources.Load<Sprite>("300");
        }
    }

    void Update()
    {
        if (Gem.scoreCount >= 400)
            StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(3f);
        if (Gem.scoreCount == 400 || Gem.scoreCount == 500)
            panelTwo.SetActive(true);
        if (Gem.scoreCount == 600)
            panelOne.SetActive(true);
    }
}
