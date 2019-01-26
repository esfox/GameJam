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

    private int currentLevel = 0;
    private Level level;

    void Start()
    {
        level = GetComponent<Level>();
    }

    /*  TODO
        - Change World State (Drey)
        - Unlock Level
     */
    public void UnlockLevel()
    {
        int levelNumber = currentLevel++;
        //level.Unlock(levelNumber);
    }

    //TODO when house is completed
    public void HouseCompleted()
    {

    }
}
