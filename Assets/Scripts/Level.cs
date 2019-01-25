using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int stages;
    public GameObject[] Blockage;

    //TODO Unblock path to next area
    public void Unlock(int level)
    {
       
        if(level == 0)
        {
            UnlockStage2();
            Destroy(Blockage[level]);
        }
        else if(level == 1)
        {
            UnlockStage3();
            Destroy(Blockage[level]);
        }
        else if (level == 2)
        {
            UnlockStage4();
            Destroy(Blockage[level]); ;
        }
    }

    void UnlockStage2()
    {
        //Animate blockage
        //IEnumerator wait for seconds, { }
        
       // Destroy(gameObject.("Stage2"));
    }

    void UnlockStage3()
    {
        //animate
    }

    void UnlockStage4()
    {
        //animate
    }
}
