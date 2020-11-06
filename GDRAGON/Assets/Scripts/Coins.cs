using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public Text coinText; // Кол-во монет
    public static int coin; // Счётчик монет
    int numSkinOne, numSkinTwo, numSkinThree, numSkinFour, numSkinFive = 0;
    int numFonOne, numFonTwo, numFonThree, numFonFour, numFonFive = 0;

    void Start()
    {
        coinText = GetComponent<Text>();
        coin = 5000;
    }

    void Update()
    {
        coinText.text = "" + coin;
    }

    public void OnClickSkinOne()
    {
        
    }

    public void OnClickSkinTwo()
    {
        if (numSkinTwo == 0)
        {
            coin -= 100;
            numSkinTwo++;
        }
    }

    public void OnClickSkinThree()
    {
        if (numSkinThree == 0)
        {
            coin -= 250;
            numSkinThree++;
        }
    }

    public void OnClickSkinFour()
    {
        if (numSkinFour == 0)
        {
            coin -= 500;
            numSkinFour++;
        }
    }

    public void OnClickSkinFive()
    {
        if (numSkinFive == 0)
        {
            coin -= 1000;
            numSkinFive++;
        }
    }

    public void OnClickFonOne()
    {

    }

    public void OnClickFonTwo()
    {
        if (numFonTwo == 0)
        {
            coin -= 100;
            numFonTwo++;
        }
    }

    public void OnClickFonThree()
    {
        if (numFonThree == 0)
        {
            coin -= 250;
            numFonThree++;
        }
    }

    public void OnClickFonFour()
    {
        if (numFonFour == 0)
        {
            coin -= 500;
            numFonFour++;
        }
    }

    public void OnClickFonFive()
    {
        if (numFonFive == 0)
        {
            coin -= 1000;
            numFonFive++;
        }
    }
}
