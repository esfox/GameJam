using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Part : MonoBehaviour
{
    [SerializeField] private int number;
    public int Number
    {
        get { return number; }
    }

    void Start()
    {
        gameObject.tag = Tags.Object;
        GetComponent<Collider2D>().isTrigger = true;
    }
}
