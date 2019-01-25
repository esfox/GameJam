﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton

    private static GameManager instance;
    public static GameManager Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        instance = this;
    }

    #endregion

    public void ObjectRetrieved()
    {

    }

    public void ObjectPickup()
    {
        
    }
}