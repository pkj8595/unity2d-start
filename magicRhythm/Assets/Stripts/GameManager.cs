﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // gameManager 싱글톤 
    public static GameManager instance { get; set; }

    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
    }
    public float noteSpeed;

    public enum judges { NONE = 0 , BAD , GOOD, PERFECT,MISS }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
