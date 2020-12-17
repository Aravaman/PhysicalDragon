using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public Text coinText; // Кол-во монет
    public static int coin = 180; // Счётчик монет
    int numSkinOne, numSkinTwo, numSkinThree, numSkinFour, numSkinFive = 0; // Скины

    void Start()
    {
        coinText = GetComponent<Text>();
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
        int sumBuy = 100;
        if (numSkinTwo == 0)
        {
            if (coin >= sumBuy)
            {
                coin -= sumBuy;
                numSkinTwo++;
            }
        }
    }

    public void OnClickSkinThree()
    {
        int sumBuy = 250;
        if (numSkinThree == 0)
        {
            if (coin >= sumBuy)
            {
                coin -= sumBuy;
                numSkinThree++;
            }
        }
    }

    public void OnClickSkinFour()
    {
        int sumBuy = 500;
        if (numSkinFour == 0)
        {
            if (coin >= sumBuy)
            {
                coin -= sumBuy;
                numSkinFour++;
            }
        }
    }

    public void OnClickSkinFive()
    {
        int sumBuy = 1000;
        if (numSkinFive == 0)
        {
            if (coin >= sumBuy)
            {
                coin -= sumBuy;
                numSkinFive++;
            }
        }
    }
}
