using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Interactable : MonoBehaviour
{
    [SerializeField] private int index;
    public int Index
    {
        get { return index; }
    }

    void Start()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == Tags.Player)
            Destroy(gameObject);
    }
}
