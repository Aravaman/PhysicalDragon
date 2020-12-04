using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClic : MonoBehaviour
{
    public GameObject panelOne; // Скрытая панель1
    public GameObject panelTwo; // Скрытая панель2

    // Скрытая панель
    public void OnClicPanelOne(bool panel)
    {
        panelOne.SetActive(panel);
    }

    // Скрытая панель
    public void OnClicPanelTwo(bool panel)
    {
        panelTwo.SetActive(panel);
    }

    // Переносит на сцену
    public void OnClickStartLaba(int laba)
    {
        SceneManager.LoadScene(laba);
    }
}