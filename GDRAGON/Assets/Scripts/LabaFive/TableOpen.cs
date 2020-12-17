using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableOpen : MonoBehaviour
{
    public GameObject panelOne;

    public void OnClicTable(bool panel)
    {
        if (Gem.scoreCount >= 2)
        {
            panelOne.SetActive(panel);
            if (Gem.scoreCount == 2)
                Gem.scoreCount++;
        }
    }
}
