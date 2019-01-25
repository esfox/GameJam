using System.Collections;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int stages;
    public GameObject[] Blockage;

    [SerializeField]
    private CameraMovement cam;
    
    [SerializeField]
    private Transform player;

    private void Start()
    {
        
    }

    //TODO Unblock path to next area
    public void Unlock(int level)
    {
       
        if(level == 0)
        {
            UnlockStage2();
            Destroy(Blockage[level]);
            UnlockStage(level);
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
    public void UnlockStage(int stage)
    {
        if(stage > Blockage.Length)
        {
            Debug.Log("incorrect stage");
            return;
        }
        StartCoroutine(AnimateAndDestroy(stage));
    }

    IEnumerator AnimateAndDestroy(int level)
    {
        if (Blockage[level] != null)
        {
            cam.target = Blockage[level].transform;
        }
        yield return new WaitForSeconds(1f);
        //play animation
        yield return new WaitForSeconds(1f); // wait until length of object animation
        Blockage[level].SetActive(false);
        if(player != null)
        {
            cam.target = player.transform;
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
