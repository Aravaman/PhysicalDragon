using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTxt : MonoBehaviour
{
    public GameObject vpr; // Нужен для закрытия вопроса
    public Color gr;
    public Color fr;
    public Image th;
    public Text t;
    public Task task;
    public TRUE trus;

    public void Check() // проверяет, правильно ли нажата кнопка
    {
        if(t.text == task.True)
        {
            th.color = gr;
            StartCoroutine(Wait());
        }
        else
        {
            th.color = fr;
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        vpr.active = false;
    }
}
