using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class House : MonoBehaviour
{
    [SerializeField] private GameObject[] parts;
    private bool[] checkList;

    [SerializeField] private Sprite completedHouse;
    private SpriteRenderer renderer;

    private int partsCompleted = 0;

    void Start()
    {
        gameObject.tag = Tags.House;
        checkList = new bool[parts.Length];
        renderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag(Tags.Player))
            CheckList(other.gameObject);
    }

    private void CheckList(GameObject other)
    {   
        Player player = other.GetComponent<Player>();
        if(!player) return;

        checkList[player.ObjectIndex] = true;
        UpdateHouse(player.ObjectIndex);

        //TODO Unlock conditions
        GameManager.Instance.UnlockLevel();
    }

    private void UpdateHouse(int part)
    {
        //TODO Update house appearance

        partsCompleted++;
        if (partsCompleted == 2)
            renderer.sprite = completedHouse;

        parts[part].SetActive(true);

        bool isComplete = true;
        foreach(bool b in checkList)
            if(!b) isComplete = false;

        if(isComplete)
        {
            //TODO when house is completed
            GameManager.Instance.HouseCompleted();
        }
    }
}
