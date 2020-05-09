﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg_play_cursor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject crosshairs;
    private Vector3 target;
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 
        transform.position.z));
        crosshairs.transform.position = new Vector2(target.x, target.y);
    }
}
