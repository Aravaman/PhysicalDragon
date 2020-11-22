using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    public int I;
    public GameObject[] tasks;

    void Start()
    {
        tasks = GameObject.FindGameObjectsWithTag("TASK");
        I = Random.Range(0, tasks.Length);
        tasks[I].transform.GetChild(0).gameObject.active = true;
    }

    public void Randowm()
    {
        StartCoroutine(Rand());
    }

    IEnumerator Rand()
    {
        yield return new WaitForSeconds(1f);
        tasks = null;
        tasks = GameObject.FindGameObjectsWithTag("TASK");
        I = Random.Range(0, tasks.Length);
        tasks[I].transform.GetChild(0).gameObject.active = true;
    }
}
