using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GropR : MonoBehaviour
{
    public Image im;
    public int op;
    public GameObject loyt;

    void Update()
    {
        string str = "" + op;
        if (Gem.scoreCount >= op)
        {
            im.sprite = Resources.Load<Sprite>(str);
            if (Gem.scoreCount == 30)
                loyt.SetActive(false);
        }
    }
}
