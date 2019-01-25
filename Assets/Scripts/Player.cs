using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Player : MonoBehaviour
{
    [SerializeField] private int objectCount;
    [SerializeField] private bool[] checkList;

    void Start()
    {
        checkList = new bool[objectCount];
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag(Tags.Object))
            checkList[other.GetComponent<Interactable>().Index] = true;
    }
}
