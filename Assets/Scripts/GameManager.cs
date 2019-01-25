using System.Collections;
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

    private Level level;

    void Start()
    {
        level = GetComponent<Level>();
    }

    /*  TODO
        - Change World State (Drey)
        - Unlock Level
     */
    public void ObjectRetrieved(int index)
    {
        level.Unlock(index);
    }
 
    public void ObjectPickup()
    {
        
    }
}
