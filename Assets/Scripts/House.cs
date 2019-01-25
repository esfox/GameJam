using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class House : MonoBehaviour
{
    [SerializeField] private int objectCount;
    [SerializeField] private bool[] checkList;

    void Start()
    {
        checkList = new bool[objectCount];
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag(Tags.Player))
            checkList[other.GetComponent<Player>().ObjectIndex] = true;
    }
}
