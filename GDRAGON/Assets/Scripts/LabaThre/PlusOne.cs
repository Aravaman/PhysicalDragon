using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusOne : MonoBehaviour
{
    public GameObject panelOne;

    public void OnClicPlus()
    {
        if (Gem.scoreCount >= 0 || Gem.scoreCount < 3)
            Gem.scoreCount += 1;
    }

    void Update()
    {
        if (Gem.scoreCount == 3)
            panelOne.SetActive(false);
}
}
