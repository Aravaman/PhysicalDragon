using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task : MonoBehaviour
{
    public TextAsset all; // Техстовый дакумент который будем читать
    string Text; // Текст вопроса с ответами
    public string TasK; // Храним вопрос
    public string Answers; // Храним ответ
    public string True; // Хранит правельный ответ
    public Text Taks;
    public Text a1;
    public Text a2;
    public Text a3;
    public Text a4;

    void Start()
    {
        Text = all.text;
        string[] s = Text.Split('/'); // Делим страку (Вопрос/ответ)
        TasK = s[0];
        Answers = s[1];
        True = s[2];
        Taks.text = TasK;
        string[] A = Answers.Split(';'); // Делим страку (ответ;ответ;...)
        a1.text = A[0];
        a2.text = A[1];
        a3.text = A[2];
        a4.text = A[3];
    }
}
