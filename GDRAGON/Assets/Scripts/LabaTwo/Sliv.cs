using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliv : MonoBehaviour
{
    public Image im;

    public void OnClic()
    {
        if(Gem.scoreCount == 100 || Gem.scoreCount == 300 || Gem.scoreCount == 500)
        {
            Gem.scoreCount += 100;
            im.sprite = Resources.Load<Sprite>("Kol2");
        }
    }
}
