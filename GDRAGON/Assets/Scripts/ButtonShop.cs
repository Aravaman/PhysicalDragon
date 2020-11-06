using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonShop : MonoBehaviour
{
    // Переносит на сцену с магазином
    public void OnClickStart()
    {
        SceneManager.LoadScene(1);
    }

    // Переносит на сцену выбора лабы
    public void OnClickStartTwo()
    {
        SceneManager.LoadScene(2);
    }

    // Возвращает в меню
    public void OnClickBack()
    {
        SceneManager.LoadScene(0);
    }
}
