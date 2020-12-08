using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrueLaba : MonoBehaviour
{
    Coins coins;
    // Возвращает в меню
    public void OnClickBack()
    {
        SceneManager.LoadScene(0);
        //coins.coin += 1000;
    }
}
