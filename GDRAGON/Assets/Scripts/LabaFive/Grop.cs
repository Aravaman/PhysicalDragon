using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grop : MonoBehaviour
{
    public Image im;
    public int op;
    public GameObject panelOne;

    void Update()
    {
        string str = "" + op;
        if (Gem.scoreCount >= op)
        {
            im.sprite = Resources.Load<Sprite>(str);
        }

        if (Gem.scoreCount >= 4)
        {
            StartCoroutine(ExampleCoroutine());
        }
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(3.0f);
        panelOne.SetActive(true);
    }
}
