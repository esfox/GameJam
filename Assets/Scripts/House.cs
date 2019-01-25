using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class House : MonoBehaviour
{
    [SerializeField] private int objectCount;
    private bool[] checkList;

    void Start()
    {
        checkList = new bool[objectCount];
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

        int index = player.ObjectIndex;
        checkList[index] = true;

        string text = "";
        foreach(bool b in checkList)
            text += b.ToString() + " ";

        print(text);
    }
}
