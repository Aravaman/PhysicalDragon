using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grad : MonoBehaviour
{
    public Image im;

    void Update()
    {
        if(Gem.scoreCount >= 2)
        {
            im.sprite = Resources.Load<Sprite>("2");
        }
    }
}
