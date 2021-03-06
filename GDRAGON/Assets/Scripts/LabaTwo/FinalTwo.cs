﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTwo : MonoBehaviour
{
    private Vector3 offset;
    public int i;
    public int plus;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (Gem.scoreCount == i)
        {
            Destroy(gameObject);
            Gem.scoreCount += plus;
        }
    }

    void OnMouseDown()
    {
        if (Gem.scoreCount == i)
        {
            offset = gameObject.transform.position -
            Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
        }
    }

    void OnMouseDrag()
    {
        if (Gem.scoreCount == i)
        {
            Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
            transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
        }
    }
}
