using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClic : MonoBehaviour
{
    public GameObject panelOne; // Скрытая панель1
    public GameObject panelTwo; // Скрытая панель2

    // Скрытая панель1 открывает её
    public void OnClicPanelOneStart()
    {
        panelOne.SetActive(true);
    }

    // Скрытая панель2 открывает её
    public void OnClicPanelTwoStart()
    {
        panelTwo.SetActive(true);
    }

    // Скрытая панель1 закрывает её
    public void OnClicPanelOneBack()
    {
        panelOne.SetActive(false);
    }

    // Скрытая панель2 закрывает её
    public void OnClicPanelTwoBack()
    {
        panelTwo.SetActive(false);
    }

    // Переносит на сцену с лабой №1
    public void OnClickStartLaba(int laba)
    {
        SceneManager.LoadScene(laba);
    }
}