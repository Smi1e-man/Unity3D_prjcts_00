﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mr_Bomb_Block : MonoBehaviour, IBlocks
{
    // Start is called before the first frame update
    void Start()
    {
        ;
    }

    // Update is called once per frame
    void Update()
    {
        ;
    }
    public void Click()
    {
        Destroy(gameObject);
    }
    public void Swipe()
    {
        Destroy(gameObject);

    }
    public void Crush()
    {
        Destroy(gameObject);
    }
}