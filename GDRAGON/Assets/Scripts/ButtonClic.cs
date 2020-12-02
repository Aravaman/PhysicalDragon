using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClic : MonoBehaviour
{
    public GameObject panelOne;
    public GameObject panelTwo;

    public void OnClicPanelOneStart()
    {
        panelOne.SetActive(true);
    }

    public void OnClicPanelTwoStart()
    {
        panelTwo.SetActive(true);
    }

    public void OnClicPanelOneBack()
    {
        panelOne.SetActive(false);
    }

    public void OnClicPanelTwoBack()
    {
        panelTwo.SetActive(false);
    }

    // Переносит на сцену с лабой №1
    public void OnClickStartLabaOne()
    {
        SceneManager.LoadScene(1);
    }

    // Переносит на сцену с лабой №2
    public void OnClickStartLabaTwo()
    {
        SceneManager.LoadScene(2);
    }

    // Переносит на сцену с лабой №3
    public void OnClicStartLabaThree()
    {
        SceneManager.LoadScene(3);
    }

    // Переносит на сцену с лабой №4
    public void OnClicStartLabaTFour()
    {
        SceneManager.LoadScene(4);
    }

    // Переносит на сцену с лабой №5
    public void OnClicStartLabaFive()
    {
        SceneManager.LoadScene(5);
    }

    // Возвращает в меню
    public void OnClickBack()
    {
        SceneManager.LoadScene(0);
    }
}
