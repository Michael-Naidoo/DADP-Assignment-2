using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DnD : MonoBehaviour
{
    private bool draging = false;
    private Vector3 offset;
    void Update()
    {
        if (draging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        draging = true;
    }

    private void OnMouseUp()
    {
        draging = false;
    }
}
