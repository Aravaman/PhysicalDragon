using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grop : MonoBehaviour
{
    public Image im;
    public int op;

    void Update()
    {
        string str = "" + op;
        if (Gem.scoreCount >= op)
        {
            im.sprite = Resources.Load<Sprite>(str);
        }
    }
}
